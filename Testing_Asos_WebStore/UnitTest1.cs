using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Testing_Asos_WebStore
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver Driver { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            Driver.Navigate().GoToUrl("https://www.asos.com/");
        }

        [TestInitialize]
        public void StartUpBeforeEveryTest()
        {
             Driver = GetChromeDriver();
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
