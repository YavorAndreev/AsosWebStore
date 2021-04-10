using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    public class WomensDressesPage
    {
        private IWebDriver Driver { get; }

        public WomensDressesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded => Driver.Title.Contains("Casual Dresses");

        
    }

}