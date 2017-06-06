using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEnd.Pages;
using FrontEnd.Main;
using FrontEnd.Pages.PreProjectPreparation;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrontEnd.Steps
{
    [Binding]
    class CalculatorAndMailSteps : MainTest
    {

        [When(@"I make calculation")]
        public void MakeCalculation()
        {
            //TableListPage tableListPage = new TableListPage(this.Driver);
            Console.WriteLine("OK");
            Thread.Sleep(1000);
            AngularCalculator angularCalculator = new AngularCalculator(Driver);
            Console.WriteLine("OK2");
            angularCalculator.SendFirstValue("5");            
        }
    }
}
