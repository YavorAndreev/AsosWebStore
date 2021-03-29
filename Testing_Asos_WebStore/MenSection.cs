using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore
{
    public class MenSection
    {
        public IWebDriver Driver { get; }
        public WebDriverWait wait;
        public MenSection(IWebDriver driver)
        {
            Driver = driver;
        }

        internal void ClickMenLink()
        {
            Driver.FindElement(By.Id("men-floor")).Click();
        }

        internal VansShoesPage ClickShoesAndChoseVans()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(7));
            Actions action = new Actions(Driver);

            var shoesLink = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@data-id='87a52035-f6fa-401f-bd58-0d259e403cbb']")));
            shoesLink.Click();
            var vansShoesLink = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(text(),'Vans')]")));
            vansShoesLink.Click();

           // action.MoveToElement(shoesLink).MoveToElement(vansShoesLink).Click().Build().Perform();

            return new VansShoesPage(Driver);
        }

        internal CheckoutPage LoadCheckoutPage()
        {
            return new CheckoutPage(Driver);
        }

        internal void ClickChosenShoesAndAddToBag()
        {
            Driver.FindElement(By.XPath("//p[contains(text(),'Vans Old Skool Gumsole trainers')]")).Click();
            Driver.FindElement(By.XPath("//*[@data-id='sizeSelect']//option[contains(text(),'43')]")).Click();
            Driver.FindElement(By.XPath("//*[@aria-label='Add to bag']")).Click();

            Actions action = new Actions(Driver);

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var miniBag = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='miniBagIcon']")));
            miniBag.Click();
            
            //var viewBagButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@data-test-id='bag-link']")));
           // viewBagButton.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='bag-total-button bag-total-button--checkout bag-total-button--checkout--total']"))).Click();
           
        }
    }
}