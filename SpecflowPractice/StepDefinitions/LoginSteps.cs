using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecflowPractice.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private Helper _helper;

        public LoginSteps(Helper helper)
        {
            _helper = helper;
        }

        [Given(@"as a user i should launch the web application")]
        public void GivenAsAUserIShouldLaunchTheWebApplication()
        {
            _helper.driver.Navigate().GoToUrl("http://automationpractice.com/");
        }
        
        [When(@"user click on SignIn button")]
        public void WhenUserClickOnSignInButton()
        {
            _helper.driver.FindElement(By.LinkText("Sign in")).Click();
        }

        [When(@"user click on Submit button")]
        public void WhenUserClickOnSubmitButton()
        {
            _helper.driver.FindElement(By.Id("SubmitLogin")).Click();
        }


        [When(@"user enter (.*) and (.*)")]
        public void WhenUserEnterUsernameAndPassword(string username,string password)
        {
            _helper.driver.FindElement(By.Id("email")).SendKeys(username);
            _helper.driver.FindElement(By.Id("passwd")).SendKeys(password);

        }

        [Then(@"user should login successfully")]
        public void ThenUserShouldLoginSuccessfully()
        {
            
        }
        
        [Then(@"I should see AddToCart")]
        public void ThenIShouldSeeAddToCart()
        {
            
        }
        
        [Then(@"shouldn't login to the applicaiton")]
        public void ThenShouldnTLoginToTheApplicaiton()
        {
            
        }
        
        [Then(@"user should not login successfully")]
        public void ThenUserShouldNotLoginSuccessfully()
        {
            
        }
    }
}
