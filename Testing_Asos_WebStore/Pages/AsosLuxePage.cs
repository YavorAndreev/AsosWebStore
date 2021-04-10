using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class AsosLuxePage
    {
        private IWebDriver Driver;

        public AsosLuxePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded
        {
            get
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(6));

                return wait.Until(ExpectedConditions.TitleContains("Women's ASOS LUXE tops"));
            }
        }
    }
}