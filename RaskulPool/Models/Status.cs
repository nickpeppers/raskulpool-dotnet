using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class Status
    {
        [JsonProperty("last_mined_height")]
        public long LastMinedHeight { get; set; }

        [JsonProperty("node_height")]
        public long NodeHeight { get; set; }
    }
}