using OpenQA.Selenium;
using System;

namespace Testing_Asos_WebStore
{
    internal class SunSetSkaterPage
    {
        private IWebDriver Driver;

        public SunSetSkaterPage(IWebDriver driver)
        {
           Driver = driver;
        }

        public bool IsLoaded => Driver.FindElement(By.XPath("//h1[contains(text(),'Sunset Skater')]")).Displayed;
        public string NikeSelected => Driver.FindElement(By.XPath("//*[@data-facet-value='Nike']")).Text;
        internal void ChooseNikeBrandFromMenu()
        {
            var nikeBrand = Driver.FindElement(By.XPath("//*[@data-facet-value='Nike']"));
            nikeBrand.Click();
            var IsNikeSelected = nikeBrand.Text;
            Console.WriteLine(IsNikeSelected);
            
        }
    }
}