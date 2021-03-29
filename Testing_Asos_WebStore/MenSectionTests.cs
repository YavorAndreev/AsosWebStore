using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Testing_Asos_WebStore
{
    [TestClass]
    public class MenSectionTests : AsosStoreTestsBasePage
    {
       

        [TestMethod]
        public void TestingMenVansShoesSectionAndPlaceOrder()
        {
            var HomePage = new AsosHomePage(Driver);

            HomePage.GoToUrl();
            HomePage.MenSection.ClickMenLink();

            var vansShoesPage = HomePage.MenSection.ClickShoesAndChoseVans();
            Assert.IsTrue(vansShoesPage.IsLoaded);

            HomePage.MenSection.ClickChosenShoesAndAddToBag();
            HomePage.ClickGoogleToLogIn();

            var checkoutPage = HomePage.MenSection.LoadCheckoutPage();
            Assert.IsTrue(checkoutPage.IsDisplayed);


         }

       
    }
}
