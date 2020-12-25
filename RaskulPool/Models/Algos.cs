using Newtonsoft.Json;

namespace RaskulPool.Models
{
    public class Algos
    {
        [JsonProperty("BeamHash")]
        public BeamHash BeamHash { get; set; }
    }
}