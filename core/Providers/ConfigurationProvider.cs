using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Providers
{
    public class ConfigurationProvider
    {
        public static T Load<T>(string filePath, string sectionName)
        {
            return JObject.Parse(File.ReadAllText(filePath)).SelectToken(sectionName).ToObject<T>();
        }
    }
}
