using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Testing_Asos_WebStore
{
    [TestClass]
    public class AsosStoreTests : AsosStoreTestsBasePage
    {
        

        [TestMethod]
        public void TestSignUpUsingJoinLink()
        {


            NavigateToWebPage();
            HomePage.ClickJoinLink();
            HomePage.FillSignUpFormAndSubmit();

            Assert.IsTrue(HomePage.RegistrationIsNotPossible);
        }

        [TestMethod]
        public void TestSignUpUsingGoogleAcct()
        {
            NavigateToWebPage();
            HomePage.ClickJoinLink();
            HomePage.ClickGoogleLinkAndFillInformation();
            
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[contains(text(),'Hi Yavor')]")).Enabled);
        }

        [TestMethod]
        public void TestLogInWithGoogleAcct()
        {
            
            NavigateToWebPage();
            HomePage.ClickMyAccountLink();
            HomePage.ClickGoogleToLogIn();

            Assert.IsTrue(HomePage.MyAccountIsDisplayed);
        }

        [TestMethod]
        public void TestMyOrdersSection()
        {

            NavigateToWebPage();
            HomePage.ClickMyOrdersLink();
            HomePage.ClickGoogleToLogIn();

            Assert.IsTrue(HomePage.MyOrdersPageIsLoaded);
        }
        
        [TestMethod]
        public void TestReturnsInformationPage()
        {
            

            NavigateToWebPage();
            ReturnsInformationPage returnsInformationPage = HomePage.ClickReturnsInformationLink();

            Assert.IsTrue(returnsInformationPage.IsLoaded);
        }

        [TestMethod]
        public void TestContactPreferencesLink() 
        {
            
            NavigateToWebPage();
            HomePage.ClickContactPreferencesLink();
            ContactPreferencesPage contactPreferencesPage =  HomePage.ClickGoogleToLogIn();

            Assert.IsTrue(contactPreferencesPage.IsDisplayed);
        }

        [TestMethod]
        public void TestFreeDeliveryLink()
        {
            NavigateToWebPage();
            var deliveryPage = HomePage.ClickFreeDeliveryLink();

            Assert.IsTrue(deliveryPage.IsDisplayed);
        }

        [TestMethod]
        public void TestEasyReturnsLink()
        {
            NavigateToWebPage();
            var easyReturnsPage = HomePage.ClickEasyReturnsLink();

            Assert.IsTrue(easyReturnsPage.IsLoaded);
        }

        
    }
}
