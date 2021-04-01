using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class OnlyBlueFredPerryProducts
    {
        private IWebDriver Driver;

        public OnlyBlueFredPerryProducts(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsLoadedProperly
        {
            get
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
                var blueShirt = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(text(),'Fred Perry oxford shirt in blue')]"))).Displayed;
                var allBlueProducts = Driver.FindElements(By.ClassName("_2qG85dG"));
                
                Console.WriteLine("All blue Fred Perry products are: " + allBlueProducts.Count);
                return blueShirt;
            }
        }
    }
}