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
    public class SearchAmazon : PageBase
    {
        #region WebElement
        private By searchbox = By.XPath(".//*[@id='twotabsearchtextbox']");
        private By suggestions = By.CssSelector("div[class='s-suggestion']");
        public By loginsuccess = By.XPath(".//*[contains(text(),'Hello,')]");
        private By showresultsfor = By.XPath(".//*[contains(text(),'Show results for')]");
        private By addtocart = By.CssSelector("span[id='submit.add-to-cart']>span>input[id='add-to-cart-button']");
        private By addtocartexist = By.XPath(".//*[contains(text(),'Add to Cart')]");
        private string exactitem = ".//*[contains(text(),'REPLACE')]";
        private string testedwindow = "";
        public By addedtocartsuccess = By.XPath(".//*[contains(text(),'Added to Cart')]");
        public By cart = By.CssSelector("a[id='hlb-view-cart-announce']");
        #endregion

        #region Actions
        public ItemDetailPage searchandselect(string searchitem, string selectitem)
        {
            ObjectRepo.driver.FindElement(searchbox).SendKeys(searchitem);
            ObjectRepo.wait.Until(ExpectedConditions.ElementExists(suggestions));
            IList<IWebElement> links = ObjectRepo.driver.FindElements(suggestions);
            foreach (IWebElement link in links)
            {
                System.Diagnostics.Trace.WriteLine(link.GetAttribute("data-keyword"));
                Console.WriteLine("selectitem: " + selectitem);
                Console.WriteLine(link.GetAttribute("data-keyword"));
                if (link.GetAttribute("data-keyword") == selectitem)
                {
                    link.Click();

                    break;
                }
            }
            return new ItemDetailPage();
        }

        public SearchAmazon searchselectandadd(string searchitem, string selectitem, string detailitem)
        {

            ObjectRepo.driver.FindElement(searchbox).SendKeys(searchitem);
            ObjectRepo.wait.Until(ExpectedConditions.ElementExists(suggestions));
            IList<IWebElement> links = ObjectRepo.driver.FindElements(suggestions);
            foreach (IWebElement link in links)
            {
                System.Diagnostics.Trace.WriteLine(link.GetAttribute("data-keyword"));
                Console.WriteLine("selectitem: " + selectitem);
                Console.WriteLine(link.GetAttribute("data-keyword"));
                if (link.GetAttribute("data-keyword") == selectitem)
                {
                    link.Click();
                    // break;

                    ObjectRepo.wait.Until(ExpectedConditions.ElementExists(showresultsfor));
                    ObjectRepo.driver.FindElement(By.XPath(exactitem.Replace("REPLACE", detailitem))).Click();
                    IReadOnlyCollection<String> windows = ObjectRepo.driver.WindowHandles;

                    foreach (String windowhandle in windows)
                    {
                        if ((windowhandle != ObjectRepo.driver.CurrentWindowHandle) && windowhandle != testedwindow)
                        {
                            testedwindow = "";
                            testedwindow = ObjectRepo.driver.CurrentWindowHandle;
                            ObjectRepo.driver.SwitchTo().Window(windowhandle);
                            break;
                        }
                    }

                    ObjectRepo.wait.Until(ExpectedConditions.ElementExists(addtocartexist));
                    ObjectRepo.driver.FindElement(addtocart).Click();
                    break;
                }
            }

            return this;
        }


        public CartPage GoToCart()
        {
            ObjectRepo.wait.Until(ExpectedConditions.ElementExists(cart));
            ObjectRepo.driver.FindElement(cart).Click();
            return new CartPage();
        }
        #endregion
    }
}
