using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Schema
{
    public class DatabaseSchema
    {
        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("column_name")]
        public string ColumnName { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }
    }
}
