using Newtonsoft.Json;
using RaskulPool.Converters;

namespace RaskulPool.Models
{
    public class Worker
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("diff")]
        public long? Diff { get; set; }

        [JsonProperty("shares")]
        public long Shares { get; set; }

        [JsonProperty("invalidshares")]
        public long? Invalidshares { get; set; }

        [JsonProperty("currRoundShares")]
        public long CurrRoundShares { get; set; }

        [JsonProperty("currRoundTime")]
        public long CurrRoundTime { get; set; }

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

        [JsonProperty("paid")]
        public long Paid { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }
    }
}