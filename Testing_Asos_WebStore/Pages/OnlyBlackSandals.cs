using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class OnlyBlackSandals
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public OnlyBlackSandals(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsProperlyLoaded
        {
            get
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                var drMartensSandals = wait.Until(ExpectedConditions.ElementExists(By.XPath("//p[contains(text(),'geraldo sandals in black')]"))).Displayed;
                return drMartensSandals;
            }
        }
    }
}