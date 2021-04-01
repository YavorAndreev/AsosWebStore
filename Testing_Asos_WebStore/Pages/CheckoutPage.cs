using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class CheckoutPage
    {
        private IWebDriver Driver;

        public CheckoutPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsDisplayed
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[contains(text(),'Oops!')]"))).Displayed;
            }
        }
    }
}