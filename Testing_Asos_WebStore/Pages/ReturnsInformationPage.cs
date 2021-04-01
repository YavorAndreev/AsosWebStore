using OpenQA.Selenium;

namespace Testing_Asos_WebStore
{
    internal class ReturnsInformationPage
    {
        private IWebDriver Driver;

        public ReturnsInformationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded => Driver.FindElement(By.XPath("//h1[contains(text(),'Returns & Refunds')]")).Displayed;
    }
}