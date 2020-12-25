using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class BeamHash
    {
        [JsonProperty("workers")]
        public long Workers { get; set; }

        [JsonProperty("hashrate")]
        public long Hashrate { get; set; }

        [JsonProperty("hashrateString")]
        public string HashrateString { get; set; }
    }
}