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
        private IWebDriver Driver { get; set; }
        private WebDriverWait wait;
        readonly Actions action;
        public bool RegistrationIsNotPossible => Driver.FindElement(By.XPath("//li[contains(text(),'Sorry, we cannot create')]")).Displayed ;
        public bool MyOrdersPageIsLoaded 
        {
            get
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
                var myOrdersUrl = wait.Until(ExpectedConditions.UrlContains("orders"));
                
                return myOrdersUrl;
            }
        } 
        public bool MyAccountIsDisplayed 
        {
            get 
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
                var welcomeMsg = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'My Account')]"))).Displayed;
                return welcomeMsg;
            }
        }

        public MenSection MenSection => new MenSection(Driver);

        public AsosHomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal void GoToUrl()
        {
            Driver.Navigate().GoToUrl("https://www.asos.com/");
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
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
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
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(6));
            
            var acctMsg = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='myAccountIcon']")));
            acctMsg.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='contactpreferences-link']"))).Click();

        }

        internal ReturnsInformationPage ClickReturnsInformationLink()
        {
            

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(6));
            var acctMsg = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='myAccountIcon']")));
            acctMsg.Click();
            var returnsLink = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='returnsinformation-link']")));
            returnsLink.Click();

            return new ReturnsInformationPage(Driver);

            
           
        }

        internal void ClickMyOrdersLink()
        {
            Driver.FindElement(By.XPath("//*[@type='accountUnfilled']")).Click();

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@data-testid='myorders-link']"))).Click();
           

            
            
        }

        internal ContactPreferencesPage ClickGoogleToLogIn()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Google')]"))).Click();

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='email']"))).SendKeys("proben1918@gmail.com");
            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();
            
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@type='password']"))).SendKeys("lordNikon");

            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();

            return new ContactPreferencesPage(Driver);
            
        }

        internal void ClickMyAccountLink()
        {
            Driver.FindElement(By.XPath("//*[@type='accountUnfilled']")).Click();

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='myaccount-link']"))).Click();

           

        }

        internal void ClickGoogleLinkAndFillInformation()
        {
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Google')]"))).Click();
            
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='email']"))).SendKeys("proben1918@gmail.com");
            
            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();
            
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@type='password']"))).SendKeys("lordNikon");
            
            Driver.FindElement(By.XPath("//*[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();
            
            bool isAcctCreated;

            try 
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
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
                
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
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

            var wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-testid='signup-link']"))).Click();
            
        }
    }
}