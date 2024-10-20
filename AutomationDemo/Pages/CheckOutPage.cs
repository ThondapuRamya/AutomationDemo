using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Pages
{
    internal class CheckOutPage
    {
        IWebDriver driver = DriverSettings.Driver;

        private IWebElement FirstName => driver.FindElement(By.Id("id='first-name']"));
        private IWebElement LastName => driver.FindElement(By.Id("id='last-name']"));
        private IWebElement ZipCode => driver.FindElement(By.Id("id='postal-code']"));
        private IWebElement ContinueBtn => driver.FindElement(By.Id("id='continue']"));

        public void FirstNameInput(string firstname)
        {
           FirstName.SendKeys(firstname);
        }
        public void LastNameInput(string lastname)
        {
            LastName.SendKeys(lastname);
        }
        public void ZipCodeInput( string zipcode)
        {
            ZipCode.SendKeys(zipcode);
        }

        public void CLickOnContinueBtn()
        {
            ContinueBtn.Click();
        }
    }
}
