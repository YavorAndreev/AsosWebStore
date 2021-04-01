using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class DeliveryAndReturnsPage
    {
        private IWebDriver Driver;

        private WebDriverWait wait;

        public DeliveryAndReturnsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsDisplayed
        {
            get
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

                var title = wait.Until(ExpectedConditions.TitleContains("ASOS Delivery "));
                return title;
            }
        }
    }
}