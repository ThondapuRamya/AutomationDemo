using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using APITestcases.Models;
using core.Providers;

namespace APITestcases
{
    public class ConfigurationProvider :core.Providers.ConfigurationProvider
    {
        private static readonly string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../", "APIDetails.json");

        public static APIDetails apiDetails => Load<APIDetails>(filepath,"APIDetails");
    }
}
