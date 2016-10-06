using OpenQA.Selenium;
using SpecFrame.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.BaseClasses
{
    public class PageBase
    {
        IWebDriver driver = ObjectRepo.driver;

        public string getTitle
        {
            get { return driver.Title; }
        }


    }
}
