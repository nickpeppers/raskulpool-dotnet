using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public partial class PoolStatsInfo
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("pools")]
        public Pools Pools { get; set; }
    }
}