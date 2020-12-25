using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class History
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("hashrate")]
        public long Hashrate { get; set; }
    }
}