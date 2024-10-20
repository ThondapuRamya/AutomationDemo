using OpenQA.Selenium;
using Reqnroll;

namespace WindowsPracticing
{
    public class DriverSettings
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get { return driver; }
            set { driver = value; }
        }
    }
}
