using Newtonsoft.Json;
using System.Collections.Generic;

namespace RaskulPool.Models
{
    public class Pending
    {
        [JsonProperty("blocks")]
        public List<object> Blocks { get; set; }

        [JsonProperty("confirms")]
        public object Confirms { get; set; }

        [JsonProperty("payments")]
        public List<object> Payments { get; set; }
    }
}