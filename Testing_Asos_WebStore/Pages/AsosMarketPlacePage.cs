using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedCondtitions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    internal class AsosMarketPlacePage
    {
        private WebDriverWait wait;
        private IWebDriver Driver { get; }

        public AsosMarketPlacePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsDisplayed => Driver.Title.Contains("ASOS Marketplace");

        internal SunSetSkaterPage ClickSunsetSkaterLink()
        {
            InitiateWaitVariable();
            Driver.FindElement(By.XPath("//a[@href='/men?ctaref=mktp|men|nav|toptab']")).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@src='https://marketplace-images.asos.com/proxy/753695060105851741.jpg']"))).Click();
            return new SunSetSkaterPage(Driver);
        }

        private void InitiateWaitVariable()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
    }
}