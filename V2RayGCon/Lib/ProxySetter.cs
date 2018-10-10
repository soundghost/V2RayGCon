﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace V2RayGCon.Lib
{
    // https://stackoverflow.com/questions/197725/programmatically-set-browser-proxy-settings-in-c-sharp
    class ProxySetter
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        #region private method
        private static RegistryKey GetRegKey(bool writeable = false)
        {
            const string subkey = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
            var key = Registry.CurrentUser.OpenSubKey(subkey, writeable);
            if (key == null)
            {
                throw new KeyNotFoundException("Reg key not found!");
            }
            return key;
        }

        static void RefreshSettings()
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
        #endregion

        #region public method
        public static Model.Data.ProxyRegKeyValue GetProxySetting()
        {
            var proxy = new Model.Data.ProxyRegKeyValue();
            using (var key = GetRegKey(false))
            {
                proxy.proxyServer = key.GetValue("ProxyServer", "").ToString();
                proxy.proxyEnable = key.GetValue("ProxyEnable", "0").ToString() == "1";
                proxy.autoConfigUrl = key.GetValue("AutoConfigURL", "").ToString();
                key.Close();
            }
            return proxy;
        }

        public static void SetProxy(Model.Data.ProxyRegKeyValue proxy)
        {
            using (var key = GetRegKey(true))
            {
                key.SetValue("AutoConfigURL", proxy.autoConfigUrl, RegistryValueKind.String);
                key.SetValue("ProxyServer", proxy.proxyServer, RegistryValueKind.String);
                key.SetValue("ProxyEnable", proxy.proxyEnable ? 1 : 0, RegistryValueKind.DWord);
                key.Close();
            }

            RefreshSettings();
        }
        #endregion
    }
}
