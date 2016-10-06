using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SpecFrame.BaseClasses;
using SpecFrame.Configuration;
using SpecFrame.CustomExceptions;
using SpecFrame.Helper;
using SpecFrame.Interfaces;
using SpecFrame.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.PageObject
{
    public class AmazonHome : PageBase
    {
        public AmazonHome()
        {
            Console.WriteLine("Inside Test initialize");
            ObjectRepo.Config = new AppConfigReader();
            ObjectRepo.ds = new DriverSetup();
            ObjectRepo.ui = new UIelements();
            ObjectRepo.driver = ObjectRepo.ds.InitDriver(ObjectRepo.driver, ObjectRepo.Config);
            ObjectRepo.wait = new WebDriverWait(ObjectRepo.driver, TimeSpan.FromSeconds(30));

        }
        #region WebElement
        public By signin = By.CssSelector("div[id='nav-tools']>a[id='nav-link-yourAccount']");
        #endregion

        #region Actions
        public AmazonLogin NavigateToLogin()
        {
            ObjectRepo.driver.FindElement(signin).Click();
            return new AmazonLogin();
        }


        #endregion



    }
}
