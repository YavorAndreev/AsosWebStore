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
            
            HomePage.GoToUrl();
            HomePage.MenSection.ClickMenLink();

            var vansShoesPage = HomePage.MenSection.ClickShoesAndChoseVans();
            Assert.IsTrue(vansShoesPage.IsLoaded);

            HomePage.MenSection.ClickChosenShoesAndAddToBag();
            HomePage.ClickGoogleToLogIn();

            var checkoutPage = HomePage.MenSection.LoadCheckoutPage();
            Assert.IsTrue(checkoutPage.IsDisplayed);

         }

        [TestMethod]
        public void TestShoppingByProductUsingFilter()
        {
            HomePage.GoToUrl();
            HomePage.MenSection.ClickMenLink();
            var menSandalsPage = HomePage.MenSection.ChoseByProduct();

            Assert.IsTrue(menSandalsPage.IsLoaded);

            var onlyBlackSandals = HomePage.MenSection.ChoseProductUsingColourFilter();
            Assert.IsTrue(onlyBlackSandals.IsProperlyLoaded);

         }

        [TestMethod]

        public void SearchProductUsingSearchBox()
        {
            HomePage.GoToUrl();
            HomePage.MenSection.ClickMenLink();
            var fredPerryPage = HomePage.MenSection.TypeProductNameInSearchBox("Fred Perry");

            Assert.IsTrue(fredPerryPage.IsLoaded);

            var onlyBlueProducts =  HomePage.MenSection.FilterProductsByColour();

            Assert.IsTrue(onlyBlueProducts.IsLoadedProperly);
        }

       
    }
}
