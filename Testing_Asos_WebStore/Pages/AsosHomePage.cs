using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;
using OpenQA.Selenium.Interactions;
using Testing_Asos_WebStore.Pages;

namespace Testing_Asos_WebStore
{
    internal class AsosHomePage
    {
        private WebDriverWait wait;

        

        private IWebDriver Driver { get; set; }
        public MenSection MenSection => new MenSection(Driver);

        public WomenSection WomenSection => new WomenSection(Driver);


        public AsosHomePage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        internal void ClickWomenLink()
        {
            InitiateWaitVariable();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("women-floor"))).Click();
        }

        
        public bool RegistrationIsNotPossible => Driver.FindElement(By.XPath("//li[contains(text(),'Sorry, we cannot create')]")).Displayed ;
        public bool MyOrdersPageIsLoaded 
        {
            get
            {
                InitiateWaitVariable();
                var myOrdersUrl = wait.Until(ExpectedConditions.UrlContains("orders"));
                
                return myOrdersUrl;
            }
        } 
        public bool MyAccountIsDisplayed 
        {
            get 
            {
                InitiateWaitVariable();
                var welcomeMsg = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'My Account')]"))).Displayed;
                return welcomeMsg;
            }
        }

        
        internal void GoToUrl()
        {
            Driver.Navigate().GoToUrl("https://www.asos.com/");
            Driver.FindElement(By.XPath("//button[@class='_1liAYhR tJuQyVP O9uX50u']")).Click();
        }

        internal void ClickMyProfileIcon()
        {
            InitiateWaitVariable();
            Driver.FindElement(By.XPath("//*[@type='accountUnfilled']")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@data-testid='signin-link']"))).Click();
        }
        internal void FillSignUpFormAndSubmit()
        {
            Driver.FindElement(By.Id("Email")).SendKeys("proben1918@gmail.com");
            Driver.FindElement(By.Id("FirstName")).SendKeys("Petar");
            Driver.FindElement(By.Id("LastName")).SendKeys("Ivanov");
            Driver.FindElement(By.Id("Password")).SendKeys("probenTest");
            Driver.FindElement(By.Id("BirthDay")).Click();
            Driver.FindElement(By.XPath("//option[@value='27']")).Click();
            Driver.FindElement(By.Id("BirthMonth")).Click();
            Driver.FindElement(By.XPath("//option[contains(text(),'January')]")).Click();
            Driver.FindElement(By.Id("BirthYear")).Click();
            Driver.FindElement(By.XPath("//option[@value='1982']")).Click();
            Driver.FindElement(By.XPath("//label[contains(text(),'Menswear')]")).Click();
            Driver.FindElement(By.Id("promosLabel")).Click();
            Driver.FindElement(By.Id("newnessLabel")).Click();
            Driver.FindElement(By.Id("register")).Click();
            

        }

        internal EasyReturnsPage ClickEasyReturnsLink()
        {
            InitiateWaitVariable();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(text(),'Easy')]"))).Click();
            
            return new EasyReturnsPage(Driver);
        }

        internal DeliveryAndReturnsPage ClickFreeDeliveryLink()
        {
            Driver.FindElement(By.XPath("//p[contains(text(),'Free')]")).Click();

            return new DeliveryAndReturnsPage(Driver);
        }

        internal void ClickContactPreferencesLink()
        {
            InitiateWaitVariable();
            
            var acctMsg = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='myAccountIcon']")));
            acctMsg.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='contactpreferences-link']"))).Click();

        }

        internal ReturnsInformationPage ClickReturnsInformationLink()
        {
            

            InitiateWaitVariable();
            var acctMsg = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='myAccountIcon']")));
            acctMsg.Click();
            var returnsLink = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='returnsinformation-link']")));
            returnsLink.Click();

            return new ReturnsInformationPage(Driver);

            
           
        }

        internal void ClickMyOrdersLink()
        {
            Driver.FindElement(By.XPath("//*[@type='accountUnfilled']")).Click();

            InitiateWaitVariable();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@data-testid='myorders-link']"))).Click();
           

            
            
        }

        internal ContactPreferencesPage ClickGoogleToLogIn()
        {
            InitiateWaitVariable();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Google')]"))).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='email']"))).SendKeys("proben1918@gmail.com");
            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@type='password']"))).SendKeys("lordNikon");

            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();

            return new ContactPreferencesPage(Driver);
            
        }

        internal void ClickMyAccountLink()
        {
            Driver.FindElement(By.XPath("//*[@type='accountUnfilled']")).Click();

            InitiateWaitVariable();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='myaccount-link']"))).Click();

           

        }

        internal void ClickGoogleLinkAndFillInformation()
        {
            InitiateWaitVariable();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Google')]"))).Click();
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='email']"))).SendKeys("proben1918@gmail.com");
            
            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@type='password']"))).SendKeys("lordNikon");
            
            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();
            
            bool isAcctCreated;

            try 
            {
       
                var acctCreated = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(text(),'Hi Yavor')]"))).Enabled;
                isAcctCreated = Convert.ToBoolean(acctCreated);
                
            }
            catch (WebDriverTimeoutException exc)
            {
                Console.WriteLine(exc.Message);
                isAcctCreated = false;
            }          

            if (isAcctCreated)
            {
                var myAcct = Driver.FindElement(By.XPath("//span[@type='accountFilled']"));
                myAcct.Click();
                
                var acctName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Hi Yavor')]"))).Text;
                
                Console.WriteLine("You have already registered account with this name: " + acctName);                
            }
            else
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("BirthDay"))).Click();
                
                Driver.FindElement(By.XPath("//option[@value='27']")).Click();
                Driver.FindElement(By.Id("BirthMonth")).Click();
                Driver.FindElement(By.XPath("//option[contains(text(),'January')]")).Click();
                Driver.FindElement(By.Id("BirthYear")).Click();
                Driver.FindElement(By.XPath("//option[@value='1982']")).Click();
                Driver.FindElement(By.XPath("//label[contains(text(),'Menswear')]")).Click();
                Driver.FindElement(By.Id("promosLabel")).Click();
                Driver.FindElement(By.Id("newnessLabel")).Click();
                Driver.FindElement(By.Id("register")).Click();
            }
           
            
        }

        internal void ClickJoinLink()
        {
            Driver.FindElement(By.XPath("//*[@type='accountUnfilled']")).Click();

            InitiateWaitVariable();
            //var wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='signup-link']"))).Click();
            
        }
        internal AsosMarketPlacePage ClickMarketPlaceLink()
        {
            Driver.FindElement(By.XPath("//a[@data-testid='marketplace']")).Click();
            return new AsosMarketPlacePage(Driver);
        }

        private void InitiateWaitVariable()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
    }
}