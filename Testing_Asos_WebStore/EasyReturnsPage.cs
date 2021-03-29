using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class EasyReturnsPage
    {
        private IWebDriver Driver;

        private WebDriverWait wait;
        public EasyReturnsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded
        {
            get
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[@class='dr-header_title']"))).Displayed;

            }
        }
    }
}
