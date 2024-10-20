using System;
using Reqnroll;
using WindowsPracticing.Pages;

namespace WindowsPracticing.Steps
{
    [Binding]
    public class NewPageStepDefinitions
    {
        NewPage newpage;
        NewPageStepDefinitions()
        {
            newpage = new NewPage();
        }
        [When("Select Home from drop down")]
        public void WhenSelectHomeFromDropDown()
        {
            newpage.ClickOnMenu();
            //throw new PendingStepException();
        }

        [Then("Home page will open")]
        public void ThenHomePageWillOpen()
        {
            newpage.PickMenuItem();
            //throw new PendingStepException();
        }
    }
}
