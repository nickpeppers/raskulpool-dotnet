using Newtonsoft.Json;
using System.Collections.Generic;

namespace RaskulPool.Models
{
    public class ApiBlocks
    {
        [JsonProperty("blocks")]
        public List<Block> Blocks { get; set; }
    }
}