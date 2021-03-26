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
        

        [TestMethod]
        public void TestSignUpUsingJoinLink()
        {
            var asosHomePage = new AsosHomePage(Driver);

            asosHomePage.GoToUrl();
            asosHomePage.ClickJoinLink();
            asosHomePage.FillSignUpFormAndSubmit();

            Assert.IsTrue(asosHomePage.RegistrationIsNotPossible);
        }

        [TestMethod]
        public void TestSignUpUsingGoogleAcct()
        {
            var asosHomePage = new AsosHomePage(Driver);
            asosHomePage.GoToUrl();
            asosHomePage.ClickJoinLink();
            asosHomePage.ClickGoogleLinkAndFillInformation();
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[contains(text(),'Hi Yavor')]")).Enabled);
        }

        [TestMethod]
        public void TestLogInWithGoogleAcct()
        {
            var asosHomePage = new AsosHomePage(Driver);
            asosHomePage.GoToUrl();
            asosHomePage.ClickMyAccountLink();
            asosHomePage.ClickGoogleToLogIn();

            Assert.IsTrue(asosHomePage.MyAccountIsDisplayed);
        }

        [TestMethod]
        public void TestMyOrdersSection()
        {
            var asosHomePage = new AsosHomePage(Driver);

            asosHomePage.GoToUrl();
            asosHomePage.ClickMyOrdersLink();
            asosHomePage.ClickGoogleToLogIn();

            Assert.IsTrue(asosHomePage.MyOrdersPageIsLoaded);
        }
        
        [TestInitialize]
        public void StartUpBeforeEveryTest()
        {
             Driver = GetChromeDriver();
             Driver.Manage().Window.Maximize();
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
