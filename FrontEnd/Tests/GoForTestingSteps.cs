using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using FrontEnd.Pages;

namespace FrontEnd.Tests 
{
    [Binding]
    class GoForTestingSteps : MainTest
    {
        TableListPage tableListPage = new TableListPage(Driver);

        [When(@"I fill the form")]
        private void WhenIFillTheForm()
        {            
            tableListPage.FillInvestmentClickDeclareInvestemnt();
            tableListPage.FillFormWithTestData();
        }
    }
}
