using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Pages
{
    internal class AddCartPage
    {
        IWebDriver driver = DriverSettings.Driver;
        private IWebElement YourCart => driver.FindElement(By.XPath("//span[text()='Your Cart']"));
        private ReadOnlyCollection<IWebElement> CartItems => driver.FindElements(By.XPath("//div[@class='cart_list']"));
        
        private ReadOnlyCollection<IWebElement> RemoveButtons => driver.FindElements(By.XPath("//button[text()='Remove']"));
        private IWebElement ContinueShopBtn => driver.FindElement(By.XPath("//button[text()='Continue Shopping']"));
        private IWebElement CheckoutBtn => driver.FindElement(By.XPath("//button[text()='Checkout']"));
        private IWebElement CartQty => driver.FindElement(By.XPath("//span[@class='shopping_cart_badge']"));

        
        public bool ValidateCartPageIsDisplayed()
        {
            return YourCart.Displayed;
        }

        public void RemoveAllExistingItemFromCart()
        {
            foreach (var button in RemoveButtons)
            {
                button.Click();
            }
          
            if (RemoveButtons.Count == 0)
            {
                Console.WriteLine("All Existing Items Deleted from Cart");
            }
            else
                throw new Exception("Unable to Delete all Items from the Cart");
        }
        public void ClickOnContinueShopBtn()
        {
            ContinueShopBtn.Click();
        }
        public bool ValidateCartQty(string expectedValue)
        {
            return CartQty.Text.Equals(expectedValue);
        }

        public void ClickOnCheckoutBtn()
        {
            CheckoutBtn.Click();
           
        }
    }
}
