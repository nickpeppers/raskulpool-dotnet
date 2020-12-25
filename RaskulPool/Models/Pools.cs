using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class Pools
    {
        [JsonProperty("beam")]
        public Beam Beam { get; set; }
    }
}