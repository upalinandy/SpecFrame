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
    public class AmazonLogin : PageBase
    {

        #region WebElement
        private By email = By.CssSelector("input[id='ap_email']");
        private By password = By.CssSelector("input[id='ap_password']");
        private By login = By.CssSelector("span[id='a-autoid-0']");
        #endregion

        #region Actions
        public SearchAmazon Login(string username, string pwd)
        {
            ObjectRepo.wait.Until(ExpectedConditions.ElementExists(email));
            ObjectRepo.driver.FindElement(email).SendKeys(username);
            ObjectRepo.driver.FindElement(password).SendKeys(pwd);
            ObjectRepo.driver.FindElement(login).Click();
            return new SearchAmazon();


        }
        #endregion
    }
}
