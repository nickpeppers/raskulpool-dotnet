using Newtonsoft.Json;
using RaskulPool.Converters;
using System.Collections.Generic;

namespace RaskulPool.Models
{
    public class Beam
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }

        [JsonProperty("poolStats")]
        public PoolStats PoolStats { get; set; }

        [JsonProperty("marketStats")]
        public object MarketStats { get; set; }

        [JsonProperty("blocks")]
        public Blocks Blocks { get; set; }

        [JsonProperty("apiBlocks")]
        public ApiBlocks ApiBlocks { get; set; }

        [JsonProperty("maxRoundTime")]
        public long MaxRoundTime { get; set; }

        [JsonProperty("shareCount")]
        public long ShareCount { get; set; }

        [JsonProperty("workers")]
        public Dictionary<string, Worker> Workers { get; set; }

        [JsonProperty("hashrate")]
        public long Hashrate { get; set; }

        [JsonProperty("hashrateString")]
        public string HashrateString { get; set; }

        [JsonProperty("luckDays")]
        [JsonConverter(typeof(LuckConverter))]
        public Luck LuckDays { get; set; }

        [JsonProperty("luckHours")]
        [JsonConverter(typeof(LuckConverter))]
        public Luck LuckHours { get; set; }

        [JsonProperty("minerCount")]
        public long MinerCount { get; set; }

        [JsonProperty("workerCount")]
        public long WorkerCount { get; set; }

        [JsonProperty("maxRoundTimeString")]
        public string MaxRoundTimeString { get; set; }
    }
}