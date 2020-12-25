using Newtonsoft.Json;
using System.Collections.Generic;

namespace RaskulPool.Models
{
    public partial class Payments
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pending")]
        public Pending Pending { get; set; }

        [JsonProperty("payments")]
        public List<object> PaymentPayments { get; set; }
    }
}