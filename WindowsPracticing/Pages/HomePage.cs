using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPracticing.Pages
{
    internal class HomePage
    {
        IWebDriver driver = DriverSettings.Driver;


        private IWebElement OpenNewWindow => driver.FindElement(By.Id("newWindowBtn"));
        private IWebElement OpenNewTab => driver.FindElement(By.Id("newTabBtn"));
        private IWebElement OpenMulWindows => driver.FindElement(By.Id("newWindowsBtn"));
        private IWebElement OpenMulTabs => driver.FindElement(By.Id("newTabsBtn"));

        public void OpenWindow()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(OpenNewWindow).Click();
        }
        public void SwitchToNewWindow()
        {
            string currentWindow = driver.CurrentWindowHandle;
            var allWindows = driver.WindowHandles;
            foreach (var windowHandle in allWindows)
            {

                if (windowHandle != currentWindow)
                    driver.SwitchTo().Window(windowHandle);
            }

        }
        public void SwitchToNewTab(string urlOfRequiredWindow)
        {
            //string currentwindow = driver.CurrentWindowHandle;
            var allWindows = driver.WindowHandles;
            foreach (var windowHandle in allWindows)
            {
                driver.SwitchTo().Window(windowHandle);
                if (driver.Url.Contains(urlOfRequiredWindow))
                 break;
            }
        }

        public void SwitchBackToParentWindow()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void OpenTab()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(OpenNewTab).Click();
        }

        public void OpenWindows()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(OpenMulWindows).Click();
        }

        public void OpenTabs()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(OpenMulTabs).Click();
        }



    }
}
