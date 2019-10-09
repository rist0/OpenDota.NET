using Newtonsoft.Json;
using System;

namespace OpenDotaDotNet.Models.Matches
{
    public class Cosmetic
    {
        [JsonProperty("creation_date")]
        public DateTimeOffset? CreationDate { get; set; }

        [JsonProperty("image_inventory")]
        public string ImageInventory { get; set; }

        [JsonProperty("image_path")]
        public string ImagePath { get; set; }

        [JsonProperty("item_description")]
        public string ItemDescription { get; set; }

        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_rarity")]
        public string ItemRarity { get; set; }

        [JsonProperty("item_type_name")]
        public string ItemTypeName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prefab")]
        public string Prefab { get; set; }

        [JsonProperty("used_by_heroes")]
        public string UsedByHeroes { get; set; }
    }
}
