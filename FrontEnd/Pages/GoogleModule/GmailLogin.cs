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
    class GmailLogin
    {
        public GmailLogin(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/nav/div/a[2]")]
        private IWebElement SignIn { get; set; }

        [FindsBy(How = How.TagName, Using = "input")]
        private IWebElement InputMail { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[contains(text(), 'OK')]")]
        //private IWebElement Ok { get; set; }

        [FindsBy(How = How.ClassName, Using = "CwaK9")]
        private IWebElement Next { get; set; }

        //*[@id="identifierNext"]/div[2]
        //[FindsBy(How = How.XPath, Using = "//*[@id='gobutton']")]
        //<span class="RveJvd snByac">Next</span>
        //<div class="ZFr60d CeoRYc"></div>

        //<content class="CwaK9"><span class="RveJvd snByac">Next</span></content>

        public void ClickSignIn()
        {
            try
            {
                SignIn.Click();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public void FillEmail()
        {
            InputMail.SendKeys("dareknet@gmail.com");
        }

        public void ClickNext()
        {
            try
            {
                Next.Click();
                Thread.Sleep(2000);
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
