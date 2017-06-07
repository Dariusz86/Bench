using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using FrontEnd.Pages;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FrontEnd.Main
{
    [Binding]
    class MainSteps : MainTest
    {
        [Given(@"I start Chrome browser")]
        private void StartBrowser()
        {
            base.StartChromeBrowser();
        }

        [Then(@"I close browser")]
        private void ThenICloseBrowser()
        {
            Thread.Sleep(1000);
            Driver.Quit();
        }

        [When(@"I navigate to (.*)")]
        private void WhenINavigateToPage(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        [When(@"I verify existence of elements on page")]
        private void VerifyExistenceOfElementsOnPage()
        {
            
        }
    }
}
