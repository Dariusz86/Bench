using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEnd.Pages;
using FrontEnd.Main;
using FrontEnd.Pages;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrontEnd.Steps
{
    [Binding]
    class CalculatorSteps : MainTest
    { 
        AngularCalculator angularCalculator = new AngularCalculator(Driver);
        
        [When(@"I insert first value: (.*)")]
        public void InsertFirstValue(int value1)
        {
            angularCalculator.SendFirstValue(value1.ToString());
        }

        [When(@"I insert second value: (.*)")]
        public void InsertSecondValue(int value2)
        {
            angularCalculator.SendSecondValue(value2.ToString());
        }

        [When(@"I do multplication")]
        public void DoMultplication()
        {
            angularCalculator.MultiplyOperation();
        }

        [Then(@"I verify results")]
        public void ThenIVerifyResults()
        {
            angularCalculator.Calculate();
            angularCalculator.VerifyResults();
        }

    }
}
