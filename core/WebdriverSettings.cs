using core.Models;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class WebDriverSettings
    {
        public static ChromeOptions ChromeOptions(BrowserConfiguration browserConfiguration)
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("intl.accept_languages", browserConfiguration.BrowserLanguage);
            options.AddAdditionalOption("resolution", "1920x1080");
            return options;
        }
    }
}
