using Newtonsoft.Json;
using RaskulPool.Converters;

namespace RaskulPool.Models
{
    public class BlockInfo
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("blockdiff")]
        public long Blockdiff { get; set; }

        [JsonProperty("category")]
        [JsonConverter(typeof(CategoryConverter))]
        public Category? Category { get; set; }
    }
}