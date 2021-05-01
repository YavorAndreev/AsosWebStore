using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing_Asos_WebStore.Tests
{
    [TestClass]
    public class MarketPlaceTests : AsosStoreTestsBasePage 
    {

        [TestMethod]
        public void TestMethod1()
        {
            NavigateToWebPage();
            var marketPlacePage =  HomePage.ClickMarketPlaceLink();
            Assert.IsTrue(condition: marketPlacePage.IsDisplayed);

            var sunSetSkaterPage =  marketPlacePage.ClickSunsetSkaterLink();
            Assert.IsTrue(sunSetSkaterPage.IsLoaded);

            sunSetSkaterPage.ChooseNikeBrandFromMenu();
            Assert.AreEqual("Nike", sunSetSkaterPage.NikeSelected);

        }

        
    }
}
