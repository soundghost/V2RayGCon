﻿using Lunar.Resources.Langs;
using ScintillaNET;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Windows.Forms;

namespace Lunar.Controllers
{
    class EditorCtrl
    {
        Services.Settings settings;
        Services.LuaServer luaServer;
        Controllers.LuaCoreCtrl luaCoreCtrl;

        Scintilla luaEditor;
        ComboBox cboxScriptName;
        Button btnSaveScript,
            btnDeleteScript,
            btnRunScript,
            btnStopScript,
            btnKillScript,
            btnClearOutput;

        RichTextBox rtboxOutput;
        Panel pnlEditorContainer;

        string preCboxScriptName = string.Empty;
        string preScriptContent = string.Empty;

        public EditorCtrl(
            ComboBox cboxScriptName,
            Button btnSaveScript,
            Button btnDeleteScript,
            Button btnRunScript,
            Button btnStopScript,
            Button btnKillScript,
            Button btnClearOutput,
            RichTextBox rtboxOutput,
            Panel pnlEditorContainer)
        {
            BindControls(
                cboxScriptName,
                btnSaveScript,
                btnDeleteScript,
                btnRunScript,
                btnStopScript,
                btnKillScript,
                btnClearOutput,
                rtboxOutput,
                pnlEditorContainer);
        }

        #region properties 
        ConcurrentQueue<string> _logCache = new ConcurrentQueue<string>();
        long logCacheUpdateTimeStamp = DateTime.Now.Ticks;
        string logCache
        {
            get => string.Join(Environment.NewLine, _logCache);
            set
            {
                _logCache.Enqueue(value);
                logCacheUpdateTimeStamp = DateTime.Now.Ticks;
                VgcApis.Libs.Utils.TrimDownConcurrentQueue(
                    _logCache, 1000, 300);
            }
        }
        #endregion

        #region public methods
        public void Run(
            VgcApis.Models.IServices.IServersService vgcServers,
            Services.Settings settings,
            Services.LuaServer luaServer)
        {
            this.settings = settings;
            this.luaServer = luaServer;
            this.luaCoreCtrl = CreateLuaCoreCtrl(
                vgcServers, settings);

            InitControls();
            BindEvents();

            updateOutputTimer.Tick += UpdateOutput;
            updateOutputTimer.Start();
        }

        LuaCoreCtrl CreateLuaCoreCtrl(
            VgcApis.Models.IServices.IServersService vgcServers,
            Services.Settings settings)
        {
            var luaApis = new Models.Apis.LuaApis();
            luaApis.Run(settings, vgcServers);
            luaApis.SetRedirectLogWorker(Log);

            var coreSettings = new Models.Data.LuaCoreSetting();

            var ctrl = new LuaCoreCtrl();
            ctrl.Run(settings, coreSettings, luaApis);
            return ctrl;
        }

        public void Cleanup()
        {
            updateOutputTimer.Stop();
            updateOutputTimer.Tick -= UpdateOutput;
            updateOutputTimer.Dispose();
        }
        #endregion

        #region private methods
        void Log(string content)
        {
            logCache = content;
        }

        Timer updateOutputTimer = new Timer { Interval = 500 };
        readonly object updateOutputLocker = new object();
        bool isOutputUpdating = false;
        long updateOutputTimeStamp = 0;

        void UpdateOutput(object sender, EventArgs args)
        {
            lock (updateOutputLocker)
            {
                if (isOutputUpdating || updateOutputTimeStamp == logCacheUpdateTimeStamp)
                {
                    return;
                }
                isOutputUpdating = true;
            }

            // form maybe closed
            try
            {
                updateOutputTimeStamp = logCacheUpdateTimeStamp;
                rtboxOutput.Text = logCache;
                VgcApis.Libs.UI.ScrollToBottom(rtboxOutput);
            }
            catch { }

            lock (updateOutputLocker)
            {
                isOutputUpdating = false;
            }
        }

        private void BindEvents()
        {
            btnKillScript.Click += (s, a) => luaCoreCtrl.Kill();

            btnStopScript.Click += (s, a) => luaCoreCtrl.Stop();

            btnRunScript.Click += (s, a) =>
            {
                luaCoreCtrl.Kill();
                luaCoreCtrl.ReplaceScript(luaEditor.Text);
                luaCoreCtrl.Start();
            };

            btnClearOutput.Click += (s, a) =>
            {
                _logCache = new ConcurrentQueue<string>();
            };

            btnDeleteScript.Click += (s, a) =>
            {
                var scriptName = cboxScriptName.Text;
                if (string.IsNullOrEmpty(scriptName)
                || !VgcApis.Libs.UI.Confirm(I18N.ConfirmRemoveScript))
                {
                    return;
                }

                if (!luaServer.RemoveScriptByName(scriptName))
                {
                    VgcApis.Libs.UI.MsgBoxAsync("", I18N.ScriptNotFound);
                }
            };

            btnSaveScript.Click += (s, a) =>
            {
                var scriptName = cboxScriptName.Text;
                if (string.IsNullOrEmpty(scriptName))
                {
                    VgcApis.Libs.UI.MsgBoxAsync("", I18N.ScriptNameNotSet);
                    return;
                }

                var success = luaServer.AddOrReplaceScript(scriptName, luaEditor.Text);
                VgcApis.Libs.UI.MsgBoxAsync("", success ? I18N.Done : I18N.Fail);
            };

            cboxScriptName.DropDown += (s, a) => ReloadScriptName();

            cboxScriptName.SelectedIndexChanged += (s, a) =>
            {
                var c = cboxScriptName;
                var scriptName = c.Text;
                if (scriptName != preCboxScriptName)
                {
                    luaEditor.Text = LoadScriptByName(scriptName);
                    preCboxScriptName = scriptName;
                }
            };
        }

        string LoadScriptByName(string name) =>
            settings.GetLuaCoreStates()
                .Where(s => s.name == name)
                .FirstOrDefault()
                ?.script
                ?? string.Empty;


        void InitControls()
        {
            // script editor
            luaEditor = Libs.UI.CreateLuaEditor(pnlEditorContainer);
        }

        void ReloadScriptName()
        {
            cboxScriptName.Items.Clear();
            foreach (var coreState in settings.GetLuaCoreStates())
            {
                cboxScriptName.Items.Add(coreState.name);
            }
        }

        private void BindControls(ComboBox cboxScriptName, Button btnSaveScript, Button btnDeleteScript, Button btnRunScript, Button btnStopScript, Button btnKillScript, Button btnClearOutput, RichTextBox rtboxOutput, Panel pnlEditorContainer)
        {
            this.cboxScriptName = cboxScriptName;
            this.btnSaveScript = btnSaveScript;
            this.btnDeleteScript = btnDeleteScript;
            this.btnRunScript = btnRunScript;
            this.btnStopScript = btnStopScript;
            this.btnKillScript = btnKillScript;
            this.btnClearOutput = btnClearOutput;
            this.rtboxOutput = rtboxOutput;
            this.pnlEditorContainer = pnlEditorContainer;
        }
        #endregion
    }
}