using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Distributions
{
    public class Mmr
    {
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("rowCount")]
        public long RowCount { get; set; }

        //[JsonProperty("oid")]
        //public object Oid { get; set; }

        [JsonProperty("rows")]
        public List<MmrRow> Rows { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        //[JsonProperty("_parsers")]
        //public List<object> Parsers { get; set; }

        //[JsonProperty("RowCtor")]
        //public object RowCtor { get; set; }

        [JsonProperty("rowAsArray")]
        public bool RowAsArray { get; set; }

        [JsonProperty("sum")]
        public Sum Sum { get; set; }
    }

    public partial class Sum
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
