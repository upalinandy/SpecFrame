using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SpecFrame.Configuration;
using SpecFrame.CustomExceptions;
using SpecFrame.Interfaces;
using SpecFrame.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.Configuration
{
    public class AppConfigReader : Iconfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.username);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.password);
        }

        public string GetUrl()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.url);
        }

        public string GetSearchItem()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.searchitem);
        }

        public string GetSelectItem()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.selectitem);
        }

        public string GetExactItem()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.exactitem);
        }

        public string GetExpLoginPage()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.loginpageurl);
        }

    }
}
