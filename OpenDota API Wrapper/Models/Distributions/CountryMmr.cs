using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Distributions
{
    public class CountryMmr
    {
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("rowCount")]
        public long RowCount { get; set; }

        //[JsonProperty("oid")]
        //public object Oid { get; set; }

        [JsonProperty("rows")]
        public List<CountryMmrRow> Rows { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        //[JsonProperty("_parsers")]
        //public List<object> Parsers { get; set; }

        //[JsonProperty("RowCtor")]
        //public object RowCtor { get; set; }

        [JsonProperty("rowAsArray")]
        public bool RowAsArray { get; set; }
    }
}
