using Newtonsoft.Json;
using RaskulPool.Converters;

namespace RaskulPool.Models
{
    public class PoolStats
    {
        [JsonProperty("validShares")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ValidShares { get; set; }

        [JsonProperty("validBlocks")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ValidBlocks { get; set; }

        [JsonProperty("invalidShares")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long InvalidShares { get; set; }

        [JsonProperty("totalPaid")]
        public long TotalPaid { get; set; }

        [JsonProperty("networkBlocks")]
        public long NetworkBlocks { get; set; }

        [JsonProperty("networkSols")]
        public long NetworkSols { get; set; }

        [JsonProperty("networkSolsString")]
        public string NetworkSolsString { get; set; }

        [JsonProperty("networkDiff")]
        public long NetworkDiff { get; set; }

        [JsonProperty("networkConnections")]
        public long NetworkConnections { get; set; }

        [JsonProperty("networkVersion")]
        public long NetworkVersion { get; set; }

        [JsonProperty("networkProtocolVersion")]
        public long NetworkProtocolVersion { get; set; }
    }
}