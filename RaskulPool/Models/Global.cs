using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class Global
    {

        [JsonProperty("workers")]
        public long Workers { get; set; }

        [JsonProperty("hashrate")]
        public long Hashrate { get; set; }
    }
}