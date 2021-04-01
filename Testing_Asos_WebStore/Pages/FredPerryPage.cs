using OpenQA.Selenium;

namespace Testing_Asos_WebStore
{
    internal class FredPerryPage
    {
        private IWebDriver Driver;

        public FredPerryPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded => Driver.FindElement(By.Id("search-term-banner")).Displayed;
    }
}