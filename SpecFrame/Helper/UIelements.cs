using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SpecFrame.Configuration;
using SpecFrame.CustomExceptions;
using SpecFrame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.Helper
{
    public class UIelements
    {
        /*
        private By signin = By.CssSelector("div[id='nav-tools']>a[id='nav-link-yourAccount']");
        private By email = By.CssSelector("input[id='ap_email']");
        private By password = By.CssSelector("input[id='ap_password']");
        private By login = By.CssSelector("span[id='a-autoid-0']");
        private By searchbox = By.XPath(".//*[@id='twotabsearchtextbox']");
        private By suggestions = By.CssSelector("div[class='s-suggestion']");

        private By addtocart = By.CssSelector("span[id='submit.add-to-cart']>span>input[id='add-to-cart-button']");
        */
        public string signin = "css=div[id='nav-tools']>a[id='nav-link-yourAccount']";
        public string email = "css=input[id='ap_email']";
        public string password = "css=input[id='ap_password']";
        public string login = "css=span[id='a-autoid-0']";
        public string searchbox = "xpath=.//*[@id='twotabsearchtextbox']";
        public string suggest = "css=div[class='s-suggestion']";
        public string addtocart = "css=span[id='submit.add-to-cart']>span>input[id='add-to-cart-button']";
        public By bylocator;

        public IWebElement getWebElement(IWebDriver driver, string locator)
        {
            //  String[] total = locator.Split('=');
            string[] total = locator.Split(new char[] { '=' }, 2);
            string locatype = total[0];
            string strlocator = total[1];
            IWebElement web = null;
            Console.WriteLine(locatype);
            Console.WriteLine(strlocator);

            try
            {
                if (locatype.Equals("css"))
                {
                    web = driver.FindElement(By.CssSelector(strlocator));
                    //      bylocator = By.CssSelector(strlocator);
                    Console.WriteLine("Now in css");
                }
                else if (locatype.Equals("xpath"))
                {
                    web = driver.FindElement(By.XPath(strlocator));
                    //     bylocator = By.XPath(strlocator);
                }
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("No such Element exception: " + e);
            }
            return web;

        }

        public By getBylocator(IWebDriver driver, string locator)
        {

            string[] total = locator.Split(new char[] { '=' }, 2);
            string locatype = total[0];
            string strlocator = total[1];
            Console.WriteLine(locatype);
            Console.WriteLine(strlocator);

            try
            {
                if (locatype.Equals("css"))
                {

                    bylocator = By.CssSelector(strlocator);
                    Console.WriteLine("Now in css");
                }
                else if (locatype.Equals("xpath"))
                {

                    bylocator = By.XPath(strlocator);
                }
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("No such Element exception: " + e);
            }
            return bylocator;

        }
        /*
        public static IWebElement getElement(By Locator)
        {
            IWebElement we = ObjectRepo.driver.FindElement(Locator);
            return we;
        }*/

        public bool IsElementPresent(IWebDriver driver, By bylocator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementExists(bylocator));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }

    }
}
