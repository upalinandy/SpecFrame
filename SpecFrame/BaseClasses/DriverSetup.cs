using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SpecFrame.Configuration;
using SpecFrame.CustomExceptions;
using SpecFrame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.BaseClasses
{
    class DriverSetup
    {
        private IWebDriver GetFirefoxDriver()
        {

            FirefoxBinary binary = new FirefoxBinary("C:\\Program Files\\Mozilla Firefox\\firefox.exe");
            var profile = new FirefoxProfile();
            IWebDriver driver = new FirefoxDriver(binary, profile);
            //   IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
        private IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        public IWebDriver InitDriver(IWebDriver driver, Iconfig Config)
        {
            Console.WriteLine("Inside InitDriver");

            switch (Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    driver = GetChromeDriver();
                    break;

                case BrowserType.IExplorer:
                    driver = GetIEDriver();
                    break;

                default:
                    throw new NoDriverFound("Driver not found : " + Config.GetBrowser().ToString());
            }
            return driver;
        }


        public void TearDown(IWebDriver driver)
        {
            if (driver != null)
            {

                driver.Quit();
            }
        }
    }
}
