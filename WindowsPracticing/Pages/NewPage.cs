using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPracticing.Pages
{
    internal class NewPage
    {
        IWebDriver driver = DriverSettings.Driver;

        private IWebElement Menu => driver.FindElement(By.Id("selectnav2"));

        private ReadOnlyCollection<IWebElement> MenuItems => driver.FindElements(By.XPath("//select[@id='selectnav2']//option"));

        public void ClickOnMenu()
        {
            Menu.Click();
        }
        public void PickMenuItem()
        {
            foreach (IWebElement Item1 in MenuItems)
            {
                if (Item1.Text.Equals("Home"))
                    Item1.Click();
            }
              
        }
        public void Alert()
        {
            IAlert alrt = driver.SwitchTo().Alert();
            alrt.Accept();
            alrt.Dismiss();
            var Text = alrt.Text;
            alrt.SendKeys("This is my first alert");
        }
    }
}
