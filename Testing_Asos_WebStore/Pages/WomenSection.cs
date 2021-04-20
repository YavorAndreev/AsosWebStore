using OpenQA.Selenium;
using System;

namespace Testing_Asos_WebStore
{
    public class WomenSection
    {
        public IWebDriver Driver { get; }
        public WomensDressesPage DressesPage => new WomensDressesPage(Driver);

        public WomenSection(IWebDriver driver)
        {
            Driver = driver;
        }

       

        internal WomensDressesPage ClickDressesLink()
        {
            Driver.FindElement(By.XPath("//p[contains(text(),'DRESSES')]")).Click();
            return new WomensDressesPage(Driver);
        }

        internal AsosLuxePage ClickAsosLuxeLink()
        {
            Driver.FindElement(By.XPath("//*[@data-analytics-id='roe-gblluxeincau-shopthebrand']")).Click();
            return new AsosLuxePage(Driver);
        }

        internal AsosSnapChatPage ClickSnapChatIcon()
        {
            Driver.FindElement(By.XPath("//*[@aria-label='Snapchat']")).Click();
            var newWindow = Driver.WindowHandles;
            Driver.SwitchTo().Window(newWindow[1]);
            return new AsosSnapChatPage(Driver);
        }
    }
}