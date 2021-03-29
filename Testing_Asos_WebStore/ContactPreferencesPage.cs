using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;
namespace Testing_Asos_WebStore
{
    internal class ContactPreferencesPage
    {
        private IWebDriver Driver;
        private WebDriverWait wait;
        public ContactPreferencesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        
        public bool IsDisplayed 
        {
            get 
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                var contactsPage = wait.Until(ExpectedConditions.TitleContains("Contact preferences | ASOS"));
                return contactsPage;
            }
        }  
    }
}