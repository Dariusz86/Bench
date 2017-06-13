using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEnd.Pages;
using TechTalk.SpecFlow;

namespace FrontEnd.Tests
{
    [Binding]
    class GoogleSteps : MainTest
    {
        GoogleSearch googleSearch = new GoogleSearch(Driver);
        GmailLogin gmailLogin = new GmailLogin(Driver);


        [When(@"I type (.*) in search box")]
        public void TypeGmailInSearchbox(string text)
        {
            googleSearch.FillSearchBox(text);
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            googleSearch.ClickSearch();
        }

        [When(@"I click gmail link")]
        public void ClickGmailLink()
        {
            googleSearch.ClickGmailLink();
        }

        [When(@"I click SignIn")]
        public void ClickSignIn()
        {
            gmailLogin.ClickSignIn();
        }

        [When(@"I write down email address")]
        public void WhenIWriteDownEmailAddress()
        {
            gmailLogin.FillEmail();
        }

        [When(@"I click next")]
        public void ClickNext()
        {
            gmailLogin.ClickNext();
        }
    }
}
