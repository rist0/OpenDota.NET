using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Matches
{
    public class AdditionalUnit
    {
        // Name of unit
        [JsonProperty("unitname")]
        public string Unitname { get; set; }

        // Id of item 0
        [JsonProperty("item_0")]
        public int Item0 { get; set; }

        // Id of item 1
        [JsonProperty("item_1")]
        public int Item1 { get; set; }

        // Id of item 2
        [JsonProperty("item_2")]
        public int Item2 { get; set; }

        // Id of item 3
        [JsonProperty("item_3")]
        public int Item3 { get; set; }

        // Id of item 4
        [JsonProperty("item_4")]
        public int Item4 { get; set; }

        // Id of item 5
        [JsonProperty("item_5")]
        public int Item5 { get; set; }

        // Id of backpack item 0
        [JsonProperty("backpack_0")]
        public int Backpack0 { get; set; }

        // Id of backpack item 1
        [JsonProperty("backpack_1")]
        public int Backpack1 { get; set; }

        // Id of backpack item 2
        [JsonProperty("backpack_2")]
        public int Backpack2 { get; set; }
    }
}
