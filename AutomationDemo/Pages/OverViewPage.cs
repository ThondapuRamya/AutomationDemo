using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Pages
{
    internal class OverViewPage
    {
        IWebDriver driver = DriverSettings.Driver;

        private ReadOnlyCollection<IWebElement> ItemnsInCart => driver.FindElements(By.XPath("//div[@class='cart_item']//a"));
        private IWebElement FinishBtn => driver.FindElement(By.Id("finish"));

        private IWebElement OrederConfirmationMsg => driver.FindElement(By.XPath("//h2[text()='Thank you for your order!']"));

        public bool ValidateCartItemsCount(int expectedCount)
        {
            return ItemnsInCart.Count.Equals(expectedCount);
        }

        public void ClickOnFinishBtn()
        {
            FinishBtn.Click();
        }

        public bool ValidateOrderConfirmation()
        {
            return OrederConfirmationMsg.Text.Equals("Thank you for your order!");
        }
    }
}
