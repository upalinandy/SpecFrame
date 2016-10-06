using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.Helper
{
    public class NavigationHelper
    {
        public static void GoToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);

        }
    }
}
