using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class MenSandalsPage
    {
        private IWebDriver Driver;
        private WebDriverWait wait;
        public MenSandalsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded 
        {
            get 
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(7));
                return wait.Until(ExpectedConditions.ElementExists(By.Id("category-banner-wrapper"))).Displayed;
            }
        }
    }
}