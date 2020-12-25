using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class Blocks
    {
        [JsonProperty("pending")]
        public long Pending { get; set; }

        [JsonProperty("confirmed")]
        public long Confirmed { get; set; }

        [JsonProperty("orphaned")]
        public long Orphaned { get; set; }
    }
}