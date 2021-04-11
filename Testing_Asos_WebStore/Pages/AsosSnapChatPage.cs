using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class AsosSnapChatPage
    {
        private IWebDriver Driver { get; }

        public AsosSnapChatPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded
        {
            get
            {
                try
                {
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(6));
                    return wait.Until(ExpectedConditions.UrlContains("asosfashion"));
                }
                catch(WebDriverTimeoutException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}