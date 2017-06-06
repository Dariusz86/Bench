using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FrontEnd;


namespace FrontEnd.Hooks
{
    [Binding]
    class BeforeAndAfterTest
    {
        // SpecFlow hooks
        // Can be used for example for opening DB connection
        // Before specific category of tests

        public IWebDriver Driver { get; set; }


        //[BeforeScenario]
        //public void Setup()
        //{
        //    this.Driver = new ChromeDriver("C:\\PTAQ\\Repo-2016_09\\Ptaq\\FrontEnd\\");
        //}

        //[BeforeScenario("mytag")]
        //public static void BeforeScenario()
        //{
        //    //ExecuteQuery.OpenConnection("Default");
        //}

        [AfterScenario]
        public static void AfterTest()
        {
            MainTest.Driver.Quit();
        }
    }
}
