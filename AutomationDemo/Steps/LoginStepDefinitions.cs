using System;
using AutomationDemo.Pages;
using NUnit.Framework;
using Reqnroll;

namespace AutomationDemo.Steps
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage loginPage;
        Homepage homepage;
        LoginStepDefinitions()
        {
            loginPage = new LoginPage();
            homepage = new Homepage();
        }
        [Given("I have entered application URL")]
        public void GivenIHaveEnteredApplicationURL()
        {
            loginPage.LaunchUrl();
        }

        [Then("Application login page will open")]
        public void ThenApplicationLoginPageWillOpen()
        {
          Assert.IsTrue(loginPage.ValidateLogop(), "Login page not displayed");
        }

        [When("I have entered user name")]
        public void WhenIHaveEnteredUserName()
        {
            loginPage.SetUser();
        }

        [When("I have entered password")]
        public void WhenIHaveEnteredPassword()
        {
            loginPage.SetPassword();
        }

        [When("Click on login button")]
        public void WhenIHaveEnteredOnLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then("Validate result")]
        public void ThenValidateResult()
        {
         Assert.IsTrue(homepage.ValidateProducts(), "Home page dispalyed");
        }

        [When("I validate menu items as All (.*)")]
        public void WhenIValidateMenuItemsAsAllItemsAboutLogoutResetAppState(string expectedItems)
        {
            var eItems = expectedItems.Split(',');
           Assert.IsTrue( homepage.ValidateMenuItems(eItems.ToList()));
        }

        [When("I have entered username as (.*)")]
        public void WhenIHaveEnteredNaresh(string username)
        {
            loginPage.SetUser(username);
        }

        [When("I have entered password as (.*)")]
        public void WhenIHaveEnteredRamya(string password)
        {
            loginPage.SetPassword(password);
        }

        [Then("Validate output (.*)")]
        public void ThenValidateOutputValid(string validinvalud)
        {
            if (validinvalud == "Valid")
                loginPage.ValidateLogop();

            else
            {
              Assert.IsTrue(  loginPage.ValidateErrorText("Username and password do not match"),"Expected error message not displayed");
            }
        }


    }
}
