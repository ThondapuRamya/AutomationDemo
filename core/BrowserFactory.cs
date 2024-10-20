using core.Enums;
using core.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace core
{
    public class BrowserFactory
    {
       public static IWebDriver GetBrowserInstance(BrowserConfiguration browserConfiguration)
        {
            switch (browserConfiguration.BrowserNames)
            {
              
                case BrowserNames.Edge:
                    IWebDriver driver1 = new EdgeDriver();
                    return driver1;
                case BrowserNames.IE:
                    IWebDriver driver2 = new InternetExplorerDriver();  
                    return driver2;
                default:// BrowserNames.Chrome:
                    var options = WebDriverSettings.ChromeOptions(browserConfiguration);
                    IWebDriver driver = new ChromeDriver(options);
                    return driver;


            }
        }
    }
}
