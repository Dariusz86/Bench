using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace FrontEnd.Pages
{
    class AngularCalculator
    {
        
        //private readonly IWebDriver driver;
        public AngularCalculator(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/h3")]
        private IWebElement Header { get; set; }

        //[FindsBy(How = How.XPath, Using = "//input[@type='text']/[1]")]
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/form/input[1]")]        
        private IWebElement FirstValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/form/select")]
        private IWebElement Operator { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/form/input[2]")]
        private IWebElement SecondValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='gobutton']")]
        private IWebElement CalculateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/table/tbody/tr/td[3]")]
        private IWebElement Result { get; set; }


        private int verificationValue1, verificationValue2;
        private string operation;


        private int VerifyCalculation ()
        {
            if (operation == "Multiplication")
                return verificationValue1 * verificationValue2;
            else
                return -1;
        }   
        
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
            Console.WriteLine("We are starting play with calculator and I insert first value: " + value1);
            FirstValue.SendKeys(value1);
            verificationValue1 = Int32.Parse(value1);
        }

        public void MultiplyOperation()
        {
            var opertion = new SelectElement(Operator);
            opertion.SelectByText("*");
            operation = "Multiplication";
        }

        public void SendSecondValue(string value2)
        {
            SecondValue.SendKeys(value2);
            verificationValue2 = Int32.Parse(value2);
        }

        public void Calculate()
        {
            CalculateButton.Click();
        }

        public void VerifyResults()
        {
            int result = Int32.Parse(Result.Text);

            if (result == VerifyCalculation())
                Console.WriteLine("Result is ok: " + result);
            else
            {
                Console.WriteLine("Result is bad");
                Assert.Fail();       
            }        
        }
    }
}
