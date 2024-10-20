using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPracticing.Common
{
    public static class ExtensionActions
    {
        public static void WaitUntilButtonIsVisible(this IWebDriver driver, IWebElement element)
        {
            try
            {
                DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
                {
                    Timeout = TimeSpan.FromSeconds(1000),
                    PollingInterval = TimeSpan.FromMilliseconds(500)
                };
                fluentWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                fluentWait.Message = "Wait till element is loaded";
                fluentWait.Until(x => element.Displayed);
            }
            catch { }
            Console.WriteLine("Button is displayed" + element.Displayed);
        }

        public static void WaitUntilOpenNewTabEnable(this IWebDriver driver, IWebElement element, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            try
            {
                wait.Until(driver => !driver.FindElement(locator).Text.Equals(element.Text));
            }
            catch { }
            Console.WriteLine("Button is enabled" + element.Enabled);
        }
    }
}

