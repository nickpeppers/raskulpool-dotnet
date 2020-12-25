using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class Stats
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("global")]
        public Global Global { get; set; }

        [JsonProperty("algos")]
        public Algos Algos { get; set; }

        [JsonProperty("pools")]
        public Pools Pools { get; set; }
    }
}