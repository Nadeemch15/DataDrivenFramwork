using System;
using TechTalk.SpecFlow;

namespace DataDrivenFramwork.Features
{
    [Binding]
    public class SuccessfullLoginUserSteps
    {
        Methods login;
        public SuccessfullLoginUserSteps()
        {
            login = new Methods();
        }

        [Given(@"I click on login link of website")]
        public void GivenIClickOnLoginLinkOfWebsite()
        {
            login.ClickLoginLink();
        }
        
        [Given(@"I entered the login details (.*), (.*)")]
        public void GivenIEnteredTheLoginDetails(string username, string password)
        {
            login.EnterUserDetials(username, password);
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            login.ClickLoginButton();
        }

        //[Then(@"I should be successfuly logged in")]
        //public void ThenIShouldBeSuccessfulyLoggedIn()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
