using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore.Pages
{
    internal class TheNorthFacePage
    {
        private IWebDriver Driver { get; }
        private WebDriverWait wait { get; }
        public TheNorthFacePage(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
        }

        public bool IsLoaded
        {
            get
            {
                try
                {
                    return Driver.FindElement(By.XPath("//div[@class='_3FyxBKb'] //h1[contains(text(),'The North')]")).Displayed;
                }
                catch(NoSuchElementException ex)
                {
                    return false;
                }
               
            }
        }

        internal void CountTheNumberOfProducts()
        {
            var totalAmountOfNortFaceProducts = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[@data-auto-id='styleCount']")));
            Console.WriteLine("The total count of The North Face products is: " + totalAmountOfNortFaceProducts.Text);
        }
    }
}