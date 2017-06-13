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
    class GmailMain
    {
        public GmailMain(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }
    }
}
