using core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize1.Providers
{
    public class ConfigProvider : ConfigurationProvider

    {
        static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../,../,../", "config.json");
        public static Model.ApplicationDetails apDetails => Load<Model.ApplicationDetails>(path,"ApplicationDetails");

        public static core.Models.BrowserConfiguration browseConfiguration => Load<core.Models.BrowserConfiguration>(path, "Environment");

    }
}
