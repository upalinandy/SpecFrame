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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFrame.PageObject
{
    public class CartPage : PageBase
    {
        #region WebElement        
        private By subtotal = By.CssSelector("span[class='a-size-medium a-text-bold']>span");
        private By products = By.CssSelector("span[class='a-size-medium sc-product-title a-text-bold']");
        private By productentry = By.CssSelector("div[class='sc-list-body']>div");
        public By cartpage = By.XPath(".//*[contains(text(),'Shopping Cart')]");
        private string deletebutton = ".//input[@aria-label='Delete REPLACE']";
        public bool itemdeleted = false;
        private string exactitem = ".//*[contains(text(),'REPLACE')]";
        public bool itemincart = false;



        #endregion

        #region Actions

        public int itemserialno(string exactitem)
        {
            Console.WriteLine("Inside itemserialno");
            int serialno = 0;
            IList<IWebElement> items = ObjectRepo.driver.FindElements(products);
            int size = items.Count;
            Console.WriteLine("list size " + size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("inside for loop itemserialno");
                Console.WriteLine("item: " + items[i].Text);
                Console.WriteLine("i " + i);
                if (items[i].Text == exactitem)
                {
                    serialno = i + 1;
                    Console.WriteLine("Inside if of itemserialno " + items[i].Text);
                }
            }
            return serialno;
        }

        public int countforitem(int serialno)
        {
            Console.WriteLine("Inside countforitem");
            int i_quant = 0;
            IList<IWebElement> items = ObjectRepo.driver.FindElements(productentry);
            if (serialno > 0)
            {
                string quant = items[serialno - 1].GetAttribute("data-quantity");
                i_quant = Convert.ToInt32(quant);
            }
            return i_quant;
        }

        public void delete(string exactitem)
        {
            int serialno = itemserialno(exactitem);
            int count = countforitem(serialno);
            Console.WriteLine("Inside delete");

            if (count > 0)
            {
                Console.WriteLine("Inside delete if");
                ObjectRepo.driver.FindElement(By.XPath(deletebutton.Replace("REPLACE", exactitem))).Click();
                Console.WriteLine("Item deleted");
                itemdeleted = true;
            }
            else
            {
                Console.WriteLine("Inside delete else");
                Console.WriteLine("No element to be deleted");
            }
        }




        public IWebElement findelement(string detailitem)
        {
            try
            {
                return ObjectRepo.driver.FindElement(By.XPath(exactitem.Replace("REPLACE", detailitem)));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public void itemexists(string detailitem)
        {
            IWebElement element = findelement(detailitem);
            if (element == null)
            { itemincart = false; }

            itemincart = true;
        }

        public void writetofile(string detailitem, bool itemincart)
        {
            if (itemincart)
            {
                StreamWriter file2 = new StreamWriter(@"C:\Specflow\file.txt", true);
                file2.WriteLine(detailitem);
                file2.Close();


            }
        }

        #endregion
    }
}
