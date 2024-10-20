using System;
using Reqnroll;
using WindowsPracticing.Pages;

namespace WindowsPracticing.Steps
{
    [Binding]
    public class HomePageStepDefinitions
    {
        HomePage homepage;
        HomePageStepDefinitions()
        {
            homepage = new HomePage();
        }

        [Given("I have entered application URL")]
        public void GivenIHaveEnteredApplicationURL()
        {
            throw new PendingStepException();
        }

        [Then("Application login page will open")]
        public void ThenApplicationLoginPageWillOpen()
        {
            throw new PendingStepException();
        }

        [When("I have clicked on Open New Window button")]
        public void WhenIHaveClickedOnOpenNewWindowButton()
        {
            homepage.OpenWindow();
            //throw new PendingStepException();
        }
        [Then("Switch to new window")]
        public void ThenSwitchToNewWindow()
        {
           homepage.SwitchToNewWindow();
        }


        [Then("Validate New window opened or not")]
        public void ThenValidateNewWindowOpenedOrNot()
        {
            //Webelement Xpath - //div[@id='header-wrappers']
            throw new PendingStepException();
        }
    }
}
