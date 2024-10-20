using System;
using AutomationDemo.Pages;
using NUnit.Framework;
using Reqnroll;

namespace AutomationDemo.Steps
{
    [Binding]
    public class ValidtateMenuItemsStepDefinitions
    {
        Homepage homepage = new Homepage();

        [When("click on MenuItems Icon")]
        public void WhenClickOnMenuItemsIcon()
        {
            homepage.ClickOnMenuIcon();

        }

        [Then("validate the Menu Items (.*)")]
        public void ThenValidateTheMenuItemsAllItemsAboutLogoutResetAppState(string expectedMenuItems)
        {
            Assert.IsTrue(homepage.ValidateMenuItems(expectedMenuItems.Split(',').ToList()),"Menu Items are different");
        }
    }
}
