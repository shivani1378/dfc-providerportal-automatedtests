﻿using System;
using System.Configuration;

namespace UITesting.ProviderPortal.TestSupport
{
    public class Configurator
    {
        private static Configurator configuratorInstance = null;

        private readonly String browser;
        private readonly String baseUrl;
        private readonly String useBS;

        private Configurator()
        {
            browser = ConfigurationManager.AppSettings["config_setting"];
            useBS = ConfigurationManager.AppSettings["useBS"];
            baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        }

        public static Configurator GetConfiguratorInstance()
        {
            if (configuratorInstance == null)
            {
                configuratorInstance = new Configurator();
            }
            return configuratorInstance;
        }

        public String GetBrowser()
        {
            return browser;
        }

        public String GetBaseUrl()
        {
            return baseUrl;
        }

        public String GetUseBS()
        {
            return useBS;
        }
    }
}