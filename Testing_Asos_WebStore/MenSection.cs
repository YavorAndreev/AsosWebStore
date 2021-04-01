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

            var shoesLink = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@data-id='87a52035-f6fa-401f-bd58-0d259e403cbb']")));
            shoesLink.Click();
            var vansShoesLink = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(text(),'Vans')]")));
            vansShoesLink.Click();

            return new VansShoesPage(Driver);
        }

        internal OnlyBlackSandals ChoseProductUsingColourFilter()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Driver.FindElement(By.XPath("//div[contains(text(),'Colour')]")).Click();
            Driver.FindElement(By.XPath("//label[@for='base_colour_4']")).Click();
            var blackSandals = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("_3J74XsK")));

            for(int i = 0; i<blackSandals.Count; i++)
            {
                Console.WriteLine(blackSandals[i].Text);
            }
            Console.WriteLine("The total number of black sandals is: " + blackSandals.Count);
            return new OnlyBlackSandals(Driver);
        }

        internal MenSandalsPage ChoseByProduct()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(7));
            var shoesLink = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@data-id='87a52035-f6fa-401f-bd58-0d259e403cbb']")));
            shoesLink.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@href = 'https://www.asos.com/men/shoes-boots-trainers/sandals/cat/?cid=6593&nlid=mw|shoes|shop+by+product|sandals']"))).Click();

            return new MenSandalsPage(Driver);
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