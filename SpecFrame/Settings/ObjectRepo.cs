using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFrame.BaseClasses;
using SpecFrame.Helper;
using SpecFrame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.Settings
{
    class ObjectRepo
    {
        public static Iconfig Config { get; set; }
        public static DriverSetup ds { get; set; }
        public static IWebDriver driver { get; set; }
        public static UIelements ui { get; set; }
        public static WebDriverWait wait { get; set; }
    }
}

