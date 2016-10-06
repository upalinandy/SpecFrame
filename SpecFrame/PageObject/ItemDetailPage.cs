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
    public class ItemDetailPage : PageBase
    {
        #region WebElement
        private string exactitem = ".//*[contains(text(),'REPLACE')]";
        private By addtocartexist = By.XPath(".//*[contains(text(),'Add to Cart')]");
        private By addtocart = By.CssSelector("span[id='submit.add-to-cart']>span>input[id='add-to-cart-button']");
        private By showresultsfor = By.XPath(".//*[contains(text(),'Show results for')]");
        public By addedtocartsuccess = By.XPath(".//*[contains(text(),'Added to Cart')]");
        public By cart = By.CssSelector("a[id='hlb-view-cart-announce']");

        #endregion

        #region Actions
        public void AddtoCart(string detailitem)
        {
            ObjectRepo.wait.Until(ExpectedConditions.ElementExists(showresultsfor));
            ObjectRepo.driver.FindElement(By.XPath(exactitem.Replace("REPLACE", detailitem))).Click();
            IReadOnlyCollection<String> windows = ObjectRepo.driver.WindowHandles;

            foreach (String windowhandle in windows)
            {
                System.Diagnostics.Trace.WriteLine(windowhandle);
                if ((windowhandle != ObjectRepo.driver.CurrentWindowHandle))
                {
                    ObjectRepo.driver.SwitchTo().Window(windowhandle);
                    break;
                }
            }
            ObjectRepo.wait.Until(ExpectedConditions.ElementExists(addtocartexist));
            ObjectRepo.driver.FindElement(addtocart).Click();

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
