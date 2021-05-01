using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Testing_Asos_WebStore.Pages
{
    public class MenSection 
    {
        public WebDriverWait wait;
        public IWebDriver Driver;

        public bool FlagIsChanged => Driver.FindElement(By.XPath("//img[@alt='Croatia']")).Displayed;

        public MenSection(IWebDriver driver)
        {
            Driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
        }

        internal void ClickMenLink()
        {
            Driver.FindElement(By.Id("men-floor")).Click();
        }

        internal VansShoesPage ClickShoesAndChoseVans()
        {

            var shoesLink = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@data-id='87a52035-f6fa-401f-bd58-0d259e403cbb']")));
            shoesLink.Click();
            var vansShoesLink = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(text(),'Vans')]")));
            vansShoesLink.Click();

            return new VansShoesPage(Driver);
        }

        internal OnlyBlackSandals ChoseProductUsingColourFilter()
        {
            
            Driver.FindElement(By.XPath("//div[contains(text(),'Colour')]")).Click();
            Driver.FindElement(By.XPath("//label[@for='base_colour_4']")).Click();
            var blackSandals = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("_3J74XsK")));

            for(int i = 0; i<blackSandals.Count; i++)
            {
                Console.WriteLine(blackSandals[i].Text);
            }

            var filteredProducts = Driver.FindElement(By.XPath("//p[@data-auto-id='styleCount']"));
            Console.WriteLine("The total number of black sandals is: " + filteredProducts.Text);
            return new OnlyBlackSandals(Driver);
        }

        internal OnlyBlueFredPerryProducts FilterProductsByColour()
        {
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(text(),'Colour')]"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[@for='base_colour_3']"))).Click();
            return new OnlyBlueFredPerryProducts(Driver);
        }

        internal TheNorthFacePage CLickTheNorthFaceLogo()
        {
            Driver.FindElement(By.XPath("//img[@alt='northface']")).Click();
            return new TheNorthFacePage(Driver);
        }

        internal void ChangeCountryAndCurrency()
        {
            
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("country"))).Click();
            Driver.FindElement(By.XPath("//*[@value='HR']")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("currency"))).Click();
            Driver.FindElement(By.XPath("//*[@value='19']")).Click();
            Driver.FindElement(By.XPath("//*[@class='_3jBV0Hh _2h9sodS']")).Click();

             
        }

        internal void ClickCountryFlag()
        {
            var flagIcon = Driver.FindElements(By.XPath("//*[@alt='Bulgaria']"));
            flagIcon[0].Click();
        }

        internal FredPerryPage TypeProductNameInSearchBox(string productName)
        {
            var searchBox = Driver.FindElement(By.Id("chrome-search"));
            searchBox.SendKeys(productName);
            Driver.FindElement(By.XPath("//*[@data-testid='search-button-inline']")).Click();
            return new FredPerryPage(Driver);
        }

        internal MenSandalsPage ChoseByProduct()
        {
           
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

            
            var miniBag = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='miniBagIcon']")));
            miniBag.Click();
            
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@class='bag-total-button bag-total-button--checkout bag-total-button--checkout--total']"))).Click();
           
        }
    }
}