using AutomationDemo.Models;
using core.Models;
using core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Providers
{
    public class ConfigurationProviders:ConfigurationProvider
    {
        static readonly string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../", "appconfig.json");

        public static ApplicationDetails applicationDetails => Load<ApplicationDetails>(filepath, "ApplicationDetails");

        public static BrowserConfiguration browserConfiguration => Load<BrowserConfiguration>(filepath, "Environment");


    }
}
