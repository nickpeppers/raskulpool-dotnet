using Newtonsoft.Json;
using System.Collections.Generic;

namespace RaskulPool.Models
{
    public class WorkerStats
    {
        [JsonProperty("miner")]
        public string Miner { get; set; }

        [JsonProperty("totalHash")]
        public long TotalHash { get; set; }

        [JsonProperty("totalShares")]
        public long TotalShares { get; set; }

        [JsonProperty("networkSols")]
        public long NetworkSols { get; set; }

        [JsonProperty("immature")]
        public long Immature { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        [JsonProperty("paid")]
        public long Paid { get; set; }

        [JsonProperty("workers")]
        public Dictionary<string, Worker> Workers { get; set; }

        [JsonProperty("history")]
        public Dictionary<string, List<History>> History { get; set; }
    }
}