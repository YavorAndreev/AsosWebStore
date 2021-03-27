using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Testing_Asos_WebStore
{
    [TestClass]
    public class AsosStoreTests
    {
        public IWebDriver Driver { get; private set; }
        internal AsosHomePage HomePage { get; private set; }

        [TestMethod]
        public void TestSignUpUsingJoinLink()
        {
            

            HomePage.GoToUrl();
            HomePage.ClickJoinLink();
            HomePage.FillSignUpFormAndSubmit();

            Assert.IsTrue(HomePage.RegistrationIsNotPossible);
        }

        [TestMethod]
        public void TestSignUpUsingGoogleAcct()
        {
            HomePage.GoToUrl();
            HomePage.ClickJoinLink();
            HomePage.ClickGoogleLinkAndFillInformation();
            
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[contains(text(),'Hi Yavor')]")).Enabled);
        }

        [TestMethod]
        public void TestLogInWithGoogleAcct()
        {
            
            HomePage.GoToUrl();
            HomePage.ClickMyAccountLink();
            HomePage.ClickGoogleToLogIn();

            Assert.IsTrue(HomePage.MyAccountIsDisplayed);
        }

        [TestMethod]
        public void TestMyOrdersSection()
        {

            HomePage.GoToUrl();
            HomePage.ClickMyOrdersLink();
            HomePage.ClickGoogleToLogIn();

            Assert.IsTrue(HomePage.MyOrdersPageIsLoaded);
        }
        
        [TestMethod]
        public void TestReturnsInformationPage()
        {
            

            HomePage.GoToUrl();
            ReturnsInformationPage returnsInformationPage = HomePage.ClickReturnsInformationLink();

            Assert.IsTrue(returnsInformationPage.IsLoaded);
        }

        [TestMethod]
        public void TestContactPreferencesLink() 
        {
            
            HomePage.GoToUrl();
            HomePage.ClickContactPreferencesLink();
            ContactPreferencesPage contactPreferencesPage =  HomePage.ClickGoogleToLogIn();

            Assert.IsTrue(contactPreferencesPage.IsDisplayed);
        }

        [TestMethod]
        public void TestFreeDeliveryLink()
        {
            HomePage.GoToUrl();
            var deliveryPage = HomePage.ClickFreeDeliveryLink();

            Assert.IsTrue(deliveryPage.IsDisplayed);
        }

        [TestMethod]
        public void TestEasyReturnsLink()
        {
            HomePage.GoToUrl();
            var easyReturnsPage = HomePage.ClickEasyReturnsLink();

            Assert.IsTrue(easyReturnsPage.IsLoaded);
        }

        [TestInitialize]
        public void StartUpBeforeEveryTest()
        {
             Driver = GetChromeDriver();
             Driver.Manage().Window.Maximize();
             
            HomePage = new AsosHomePage(Driver);
        }

        [TestCleanup]
        public void CleanUpAfterEveryTest()
        {
            Driver.Close();
            Driver.Quit();
        }

        private IWebDriver GetChromeDriver()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(path);
            
        }
    }
}
