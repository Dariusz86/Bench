using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FrontEnd
{
    class MainTest
    {
        public static IWebDriver Driver { get; set; }
        //public static WebDriverWait Wait { get; set; }

        //[SetUp]
        public void StartChromeBrowser()
        {
            Driver = new ChromeDriver("C:\\PTAQ\\Repo-2016_09\\Ptaq\\FrontEnd\\");
            //Driver.Manage().Timeouts().PageLoadTimeout(TimeSpan.FromSeconds(40));
            //Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            //IS not working
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            //Wait.PollingInterval = TimeSpan.FromSeconds(1);
        }

        [TearDown]
        public void cleanUp()
        {
            Driver.Close();
        }

    }
}
