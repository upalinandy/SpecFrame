using NUnit.Framework;
using SpecFrame.Helper;
using SpecFrame.PageObject;
using SpecFrame.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFrame.StepDefinitionFiles
{
    [Binding]
    public sealed class UI_Steps
    {

        private AmazonHome ah;
        private AmazonLogin al;
        private static SearchAmazon sa;
        private ItemDetailPage id;
        private CartPage cp;

        #region Given
        [Given(@"User is at Amazon homepage with url ""(.*)""")]
        public void GivenUserIsAtAmazonHomepageWithUrl(string url)
        {
            ah = new AmazonHome();
            NavigationHelper.GoToUrl(ObjectRepo.driver, url);
        }

        [Given(@"Signin link should be visible")]
        public void GivenSigninLinkShouldBeVisible()
        {
            Assert.IsTrue(ObjectRepo.ui.IsElementPresent(ObjectRepo.driver, ah.signin));
        }
        #endregion
        #region When

        [When(@"User clicks on ""(.*)"" link")]
        public void WhenUserClicksOnLink(string p0)
        {
            al = ah.NavigateToLogin();
        }

        [When(@"User provides ""(.*)"" and ""(.*)"" and click on login button")]
        public void WhenUserProvidesAndAndClickOnLoginButton(string username, string password)
        {
            sa = al.Login(username, password);
        }

        [When(@"User provides ""(.*)"",""(.*)"" in search tab")]
        public void WhenUserProvidesInSearchTab(string searchitem, string selectitem)
        {
            id = sa.searchandselect(searchitem, selectitem);
        }

        [When(@"User selects ""(.*)"" and adds to cart")]
        public void WhenUserSelectsAndAddsToCart(string exactitem)
        {
            id.AddtoCart(exactitem);
        }

        [When(@"User clicks on ""(.*)"" link after adding to cart")]
        public void WhenUserClicksOnLinkAfterAddingToCart(string p0)
        {
            cp = id.GoToCart();
        }

        [When(@"User clicks to delete item ""(.*)"" from cart")]
        public void WhenUserClicksToDeleteItemFromCart(string exactitem)
        {
            cp.delete(exactitem);
        }

        [When(@"User provides ""(.*)"",""(.*)"" and click on login button")]
        public void WhenUserProvidesAndClickOnLoginButton(string un, string pwd)
        {
            sa = al.Login(un, pwd);
        }

        [When(@"""(.*)"" is present in cart")]
        public void WhenIsPresentInCart(string exactitem)
        {
            cp.itemexists(exactitem);
        }

        [Then(@"write to file ""(.*)""")]
        public void ThenWriteToFile(string exactitem)
        {
            cp.writetofile(exactitem, cp.itemincart);
        }

        #endregion
        #region Then

        [Then(@"User should be at Login Page")]
        public void ThenUserShouldBeAtLoginPage()
        {
            Assert.AreEqual(ObjectRepo.Config.GetExpLoginPage(), al.getTitle);
        }

        [Then(@"User should be able to login successfully\.")]
        public void ThenUserShouldBeAbleToLoginSuccessfully_()
        {
            Assert.IsTrue(ObjectRepo.ui.IsElementPresent(ObjectRepo.driver, sa.loginsuccess));
        }

        [Then(@"User should be taken to ""(.*)"" Display page\.")]
        public void ThenUserShouldBeTakenToDisplayPage_(string displaypage)
        {
            Console.WriteLine("Upali");
            Console.WriteLine(id.getTitle);
            Assert.AreEqual(displaypage, id.getTitle);
        }

        [Then(@"the specific item is added to cart")]
        public void ThenTheSpecificItemIsAddedToCart()
        {
            Assert.IsTrue(ObjectRepo.ui.IsElementPresent(ObjectRepo.driver, sa.addedtocartsuccess));
        }

        [Then(@"user is taken to cartpage")]
        public void ThenUserIsTakenToCartpage()
        {
            Assert.IsTrue(ObjectRepo.ui.IsElementPresent(ObjectRepo.driver, cp.cartpage));
        }

        [Then(@"item is deleted from cart")]
        public void ThenItemIsDeletedFromCart()
        {
            Assert.IsTrue(cp.itemdeleted);
        }
        #endregion

    }
}

