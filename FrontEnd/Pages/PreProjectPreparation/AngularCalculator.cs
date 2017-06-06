using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace FrontEnd.Pages.PreProjectPreparation
{
    class AngularCalculator
    {
        
        //private readonly IWebDriver driver;
        public AngularCalculator(IWebDriver browser)
        {
            //this.driver = browser;
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15000);
            //WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            RetryingElementLocator retry = new RetryingElementLocator(browser, TimeSpan.FromSeconds(10));
            IPageObjectMemberDecorator decor = new DefaultPageObjectMemberDecorator();
            //PageFactory.InitElements(retry.SearchContext, this, decor);

            //PageFactory.InitElements(retry.SearchContext, this, decor);
            PageFactory.InitElements(browser, this);
            Console.WriteLine("Konstruktor");
        }

        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='q']"))).SendKeys(value);


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/h3")]
        private IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='text']/[1]")]
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/form/input[1]")]        
        private IWebElement FirstValue { get; set; }
        
        public void VerifyExistanceOfElements()
        {

        }
        


        public bool VerifyHeader()
        {
            if (Header.Text == "Super Calculator")
                return true;
            else
                return false;
        }

        public void SendFirstValue(string value1)
        {
            Console.WriteLine("Zaczynamy zabawe z kalkulatorem " + value1);
            FirstValue.SendKeys(value1);
        }
    }
}
