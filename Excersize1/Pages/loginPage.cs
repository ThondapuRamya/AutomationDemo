using Excersize1.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize1.Pages
{
    public class LoginPage
    {
        IWebDriver driver = DriverSettings.Driver;

        private IWebElement logo => driver.FindElement(By.XPath("//img[@src='/static/images/home/logo.png']"));

        private IWebElement loginEmail => driver.FindElement(By.XPath("//input[@name='email'][@data-qa='login-email']"));
        private IWebElement loginPassword => driver.FindElement(By.XPath("//input[@name='password'][@data-qa='login-password']"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//button[@data-qa='login-button'][@type='submit']"));

        private IWebElement signUpUser => driver.FindElement(By.XPath("//input[@data-qa='signup-name']"));
        private IWebElement signUpEmail => driver.FindElement(By.XPath("//input[@data-qa='signup-email']"));
        private IWebElement signUpButton => driver.FindElement(By.XPath("//button[@data-qa='signup-button']"));

    }
}
