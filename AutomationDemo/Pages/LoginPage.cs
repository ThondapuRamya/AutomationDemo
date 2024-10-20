using AutomationDemo.Models;
using AutomationDemo.Providers;
using core.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.Runtime;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Pages
{
    internal class LoginPage
    {
        IWebDriver driver = DriverSettings.Driver;
        private IWebElement Username => driver.FindElement(By.Id("user-name"));
        private IWebElement Password => driver.FindElement(By.Id("password"));
        private IWebElement LogButton => driver.FindElement(By.Id("login-button"));
        private IWebElement Logo => driver.FindElement(By.ClassName("login_logo"));
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("//h3[@data-test='error']"));

        #region action methods

        public void LaunchUrl()
        {
            driver.Navigate().GoToUrl(ConfigurationProviders.applicationDetails.ApplicationUrl);
        }
        public void SetUser(string username)
        {
            Username.SendKeys(username);
        }

        public void SetUser()
        {
            var name = ConfigurationProviders.applicationDetails.UserName;
            Username.SendKeys(name);
        }

        public void SetPassword(string password)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(Password).SendKeys(password);         
        }

        public void SetPassword()
        {
            var pass = ConfigurationProviders.applicationDetails.Password;
            Password.SendKeys(pass);
        }

        public void ClickLogin()
        {
            LogButton.Click();
        }

        public bool ValidateLogop()
        {
           return Logo.Text.Equals("Swag Labs");            
        }

        public bool ValidateErrorText(string input)
        {
           return ErrorMessage.Text.Contains(input);
        }
        #endregion




    }
}
