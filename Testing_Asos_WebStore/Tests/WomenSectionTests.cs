using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing_Asos_WebStore.Tests
{
    [TestClass]
    public class WomenSectionTests : AsosStoreTestsBasePage
    {
        [TestMethod]
        public void TestBuyingFredPerryDress()
        {
            NavigateToWebPage();
            HomePage.ClickMyProfileIcon();
            HomePage.ClickGoogleToLogIn();
            HomePage.ClickWomenLink();
            var womensDressesPage = HomePage.WomenSection.ClickDressesLink();

            Assert.IsTrue(womensDressesPage.IsLoaded);
            
        }

        [TestMethod]
        public void TestSelectAsosLuxeBrand()
        {
            NavigateToWebPage();
            HomePage.ClickWomenLink();
            var asosLuxePage = HomePage.WomenSection.ClickAsosLuxeLink();

            Assert.IsTrue(asosLuxePage.IsLoaded);
        }

        [TestMethod]
        public void TestAsosSnapChatPage()
        {
            NavigateToWebPage();
            HomePage.ClickWomenLink();
            var asosSnapChatPage = HomePage.WomenSection.ClickSnapChatIcon();

            Assert.IsTrue(asosSnapChatPage.IsLoaded, "You are on a wrong webpage");

        }

        
    }
}
