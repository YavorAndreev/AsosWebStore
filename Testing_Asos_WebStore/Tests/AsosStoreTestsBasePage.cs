using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Testing_Asos_WebStore
{
    [TestClass]
    public class AsosStoreTestsBasePage
    {
        public IWebDriver Driver { get; private set; }
        internal AsosHomePage HomePage { get; private set; }

        public IWebDriver GetWebDriver()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(path);
        }

        protected void NavigateToWebPage()
        {
            HomePage.GoToUrl();
        }

        [TestInitialize]
        public void StartUpBeforeEveryTest()
        {
            Driver = GetWebDriver();
            Driver.Manage().Window.Maximize();

            HomePage = new AsosHomePage(Driver);
        }

        [TestCleanup]
        public void CloseAfterEveryTest()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
