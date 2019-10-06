using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Distributions
{
    public class Field
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tableID")]
        public long TableId { get; set; }

        [JsonProperty("columnID")]
        public long ColumnId { get; set; }

        [JsonProperty("dataTypeID")]
        public long DataTypeId { get; set; }

        [JsonProperty("dataTypeSize")]
        public long DataTypeSize { get; set; }

        [JsonProperty("dataTypeModifier")]
        public long DataTypeModifier { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }
}
