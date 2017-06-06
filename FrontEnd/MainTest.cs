using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
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
            Driver = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriver"]);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void cleanUp()
        {
            Driver.Close();
        }

    }
}
