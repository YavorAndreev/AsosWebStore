using OpenQA.Selenium;

namespace Testing_Asos_WebStore
{
    internal class VansShoesPage
    {
        private IWebDriver Driver;

        public VansShoesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoaded => Driver.Title.Contains("Vans | Vans Shoes,");
    }
}