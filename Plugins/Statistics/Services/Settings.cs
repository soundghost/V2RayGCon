﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Statistics.Services
{
    public class Settings
    {
        VgcApis.Models.ISettingService vgcSetting;
        VgcApis.Models.IServersService vgcServers;

        Models.UserSettings userSettins;
        VgcApis.Libs.Sys.LazyGuy bookKeeper;
        Timer bgStatsDataUpdateTimer = null;

        #region properties
        public int statsDataUpdateInterval { get; } = 2000;
        public bool isRequireClearStatsData { get; set; } = false;
        const int bgStatsDataUpdateInterval = 5 * 60 * 1000;
        #endregion

        #region public method
        public void RequireHistoryStatsDatasUpdate()
        {
            if (isUpdating)
            {
                return;
            }
            UpdateHistoryStatsDatasWorker();
        }

        void ClearStatsData()
        {
            userSettins.statsData =
                new Dictionary<string, Models.StatsResult>();
            bookKeeper.DoItLater();
        }

        public Dictionary<string, Models.StatsResult> GetAllStatsData()
        {
            return userSettins.statsData;
        }

        public void Run(
            VgcApis.Models.ISettingService vgcSetting,
            VgcApis.Models.IServersService vgcServers)
        {
            this.vgcSetting = vgcSetting;
            this.vgcServers = vgcServers;

            userSettins = LoadUserSetting();
            bookKeeper = new VgcApis.Libs.Sys.LazyGuy(
                SaveUserSetting, 1000 * 60 * 5);
            StartBgStatsDataUpdateTimer();
            vgcServers.OnCoreClosing += OnCoreClosingHandler;
        }

        public void Cleanup()
        {
            vgcServers.OnCoreClosing -= OnCoreClosingHandler;
            ReleaseBgStatsDataUpdateTimer();
            UpdateHistoryStatsDatasWorker();
            bookKeeper.DoItNow();
            bookKeeper.Quit();
        }
        #endregion

        #region private method
        void OnCoreClosingHandler(
            object sender,
            VgcApis.Models.StrEvent args)
        {
            var uid = args.Data;
            var coreCtrl = vgcServers
                .GetAllServersList()
                .FirstOrDefault(s => s.GetUid() == uid);
            if (coreCtrl == null)
            {
                return;
            }
            var sample = coreCtrl.Peek();
            var title = coreCtrl.GetTitle();
            Task.Factory.StartNew(
                () => AddToHistoryStatsData(uid, title, sample));
        }

        void AddToHistoryStatsData(
            string uid,
            string title,
            VgcApis.Models.StatsSample sample)
        {
            var datas = userSettins.statsData;
            if (datas.ContainsKey(uid))
            {
                datas[uid].totalDown += sample.statsDownlink;
                datas[uid].totalUp += sample.statsUplink;
                return;
            }
            datas[uid] = new Models.StatsResult
            {
                uid = uid,
                title = title,
                totalDown = sample.statsDownlink,
                totalUp = sample.statsUplink,
            };
        }

        void BgStatsDataUpdateHandler(object sender, EventArgs args)
        {
            if (isUpdating)
            {
                return;
            }
            RequireHistoryStatsDatasUpdate();
        }

        void StartBgStatsDataUpdateTimer()
        {
            bgStatsDataUpdateTimer = new Timer
            {
                Interval = bgStatsDataUpdateInterval,
            };
            bgStatsDataUpdateTimer.Start();
        }

        void ReleaseBgStatsDataUpdateTimer()
        {
            if (bgStatsDataUpdateTimer == null)
            {
                return;
            }
            bgStatsDataUpdateTimer.Stop();
            bgStatsDataUpdateTimer.Elapsed -= BgStatsDataUpdateHandler;
            bgStatsDataUpdateTimer.Dispose();
        }

        bool isUpdating = false;
        readonly object updateHistoryStatsDatasLocker = new object();
        void UpdateHistoryStatsDatasWorker()
        {
            lock (updateHistoryStatsDatasLocker)
            {
                isUpdating = true;
                var newDatas = vgcServers
                    .GetAllServersList()
                    .Where(s => s.IsCoreRunning())
                    .OrderBy(s => s.GetIndex())
                    .Select(s => GetterCoreInfo(s))
                    .ToList();

                if (isRequireClearStatsData)
                {
                    userSettins.statsData =
                        new Dictionary<string, Models.StatsResult>();
                    isRequireClearStatsData = false;
                }

                var historyDatas = userSettins.statsData;
                ResetCurSpeed(historyDatas);

                foreach (var d in newDatas)
                {
                    var uid = d.uid;
                    if (!historyDatas.ContainsKey(uid))
                    {
                        historyDatas[uid] = d;
                        return;
                    }
                    MergeNewDataIntoHistoryDatas(historyDatas, d, uid);
                }

                bookKeeper.DoItLater();
                isUpdating = false;
            }
        }

        void MergeNewDataIntoHistoryDatas(
            Dictionary<string, Models.StatsResult> datas,
            Models.StatsResult statsResult,
            string uid)
        {
            var p = datas[uid];

            var elapse = 1.0 * (statsResult.stamp - p.stamp) / TimeSpan.TicksPerSecond;
            if (elapse <= 1)
            {
                elapse = statsDataUpdateInterval / 1000.0;
            }

            var downSpeed = (statsResult.totalDown / elapse) / 1024.0;
            var upSpeed = (statsResult.totalUp / elapse) / 1024.0;
            p.curDownSpeed = Math.Max(0, (int)downSpeed);
            p.curUpSpeed = Math.Max(0, (int)upSpeed);
            p.stamp = statsResult.stamp;
            p.totalDown = p.totalDown + statsResult.totalDown;
            p.totalUp = p.totalUp + statsResult.totalUp;
        }

        void ResetCurSpeed(Dictionary<string, Models.StatsResult> datas)
        {
            foreach (var data in datas)
            {
                data.Value.curDownSpeed = 0;
                data.Value.curUpSpeed = 0;
            }
        }

        Models.StatsResult GetterCoreInfo(VgcApis.Models.ICoreCtrl coreCtrl)
        {
            var result = new Models.StatsResult();
            result.title = coreCtrl.GetTitle();
            result.uid = coreCtrl.GetUid();

            var curData = coreCtrl.Peek();
            if (curData != null)
            {
                result.stamp = curData.stamp;
                result.totalUp = curData.statsUplink;
                result.totalDown = curData.statsDownlink;
            }
            return result;
        }

        void SaveUserSetting()
        {
            vgcSetting.SavePluginsSetting(
                Properties.Resources.Name,
                VgcApis.Libs.Utils.SerializeObject(userSettins));
        }

        Models.UserSettings LoadUserSetting()
        {
            string uss = vgcSetting.GetPluginsSetting(
                Properties.Resources.Name);
            try
            {
                var us = VgcApis.Libs.Utils
                    .DeserializeObject<Models.UserSettings>(uss);
                if (us != null)
                {
                    return us;
                }
            }
            catch { }
            return new Models.UserSettings();
        }
        #endregion
    }
}