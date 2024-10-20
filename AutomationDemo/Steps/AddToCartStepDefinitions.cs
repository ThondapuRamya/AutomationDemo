using System;
using AutomationDemo.Pages;
using NUnit.Framework;
using Reqnroll;

namespace AutomationDemo.Steps
{
    [Binding]
    public class AddToCartStepDefinitions
    {
        Homepage homepage;
        AddCartPage addcartpage;
        CheckOutPage checkout;
        OverViewPage overview;

        public AddToCartStepDefinitions()
        {
            homepage = new Homepage();  
            addcartpage = new AddCartPage();    
            checkout = new CheckOutPage();
            overview = new OverViewPage();
        }
        [When("click on Cart Icon")]
        public void WhenClickOnCartIcon()
        {
            homepage.ClickOnCart();
        }

        [Then("validate cart page is displayed")]
        public void ThenValidateCartPageIsDisplayed()
        {
            Assert.IsTrue(addcartpage.ValidateCartPageIsDisplayed(), "Cart page is not opened");
        }

        [When("Remove all items from existing cart")]
        public void WhenRemoveAllItemsFromExistingCart()
        {
            addcartpage.RemoveAllExistingItemFromCart();
        }

        [When("Click on continue shoping button")]
        public void WhenClickOnContinueShopingButton()
        {
            addcartpage.ClickOnContinueShopBtn();
        }

        [When("Add first item to the cart")]
        public void WhenAddFirstItemToTheCart()
        {
            homepage.ClickOnAddToCartBtn();
        }

        [Then("Validate cart count as (.*)")]
        public void ThenValidateCartCount(string expectedValue)
        {
            Assert.IsTrue(addcartpage.ValidateCartQty(expectedValue), "Cart quantity is mismatched");
        }

        [When("Click on checkout button")]
        public void WhenClickOnCheckoutButton()
        {
            addcartpage.ClickOnCheckoutBtn();
        }

        [Then("Validate item quantity as (.*)")]
        public void ThenValidateItemQuantityAs(int expectedItemCount)
        {
            Assert.IsTrue(overview.ValidateCartItemsCount(expectedItemCount),"No. of Items in /checkout page is not matched");

        }

        [Then("Provide firstname as (.*)")]
        public void ThenProvideFirstname(string firstname)
        {
            checkout.FirstNameInput(firstname);
        }

        [Then("Provide lastname as (.*)")]
        public void ThenProvideLastname(string lastname)
        {
            checkout.LastNameInput(lastname);
        }

        [Then("provide zip code as (.*)")]
        public void ThenProvideZipCode(string zip)
        {
            checkout.ZipCodeInput(zip);
        }

        [Then("click on Finish")]
        public void ThenClickOnFinish()
        {
            overview.ClickOnFinishBtn();
        }

        [Then("Validate order placed message")]
        public void ThenValidateOrderPlacedMessage()
        {
            Assert.IsTrue(overview.ValidateOrderConfirmation(), "Order confirmation messgae is not displayed properly");
        }

    }
}
