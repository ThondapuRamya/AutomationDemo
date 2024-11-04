using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestcases.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Data
    {
        public string color { get; set; }
        public string capacity { get; set; }

        [JsonProperty("capacity GB")]
        public int? capacityGB { get; set; }
        public double? price { get; set; }
        public string generation { get; set; }
        public int? year { get; set; }

        [JsonProperty("CPU model")]
        public string CPUmodel { get; set; }

        [JsonProperty("Hard disk size")]
        public string Harddisksize { get; set; }

        [JsonProperty("Strap Colour")]
        public string StrapColour { get; set; }

        [JsonProperty("Case Size")]
        public string CaseSize { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }

        [JsonProperty("Screen size")]
        public double? Screensize { get; set; }
        public string Generation { get; set; }
        public string Price { get; set; }
    }

    public class GetObjectsResponce
    {
        public string id { get; set; }
        public string name { get; set; }
        public Data data { get; set; }
    }


}
