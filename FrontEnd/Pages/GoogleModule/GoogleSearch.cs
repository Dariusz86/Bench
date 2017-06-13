using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace FrontEnd.Pages
{
    class GoogleSearch
    {
        public GoogleSearch(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.ClassName, Using = "gsfi")]
        private IWebElement SearchText { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Gmail - G")]
        private IWebElement GmailLink { get; set; }


        public void FillSearchBox(string text1)
        {
            Console.WriteLine("Refilling search box: " + text1);
            SearchText.SendKeys(text1);
        }

        public void ClickSearch()
        {
            try
            {                
                SearchButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }         
        }

        public void ClickGmailLink()
        {
            try
            {
                GmailLink.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }
    }
}
