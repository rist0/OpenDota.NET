using Newtonsoft.Json;
using OpenDotaDotNet.Enums;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Heroes
{
    public class Hero
    {
        /// <summary>
        /// Numeric identifier for the hero object
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Dota hero command name, e.g. 'npc_dota_hero_antimage'
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Hero name, e.g. 'Anti-Mage'
        /// </summary>
        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }

        /// <summary>
        /// Hero primary shorthand attribute name, e.g. 'agi'
        /// </summary>
        [JsonProperty("primary_attr")]
        public HeroPrimaryAttribute PrimaryAttribute { get; set; }

        /// <summary>
        /// Hero attack type, either 'Melee' or 'Ranged'
        /// </summary>
        [JsonProperty("attack_type")]
        public HeroAttackType AttackType { get; set; }

        /// <summary>
        /// A hero's role in the game
        /// </summary>
        [JsonProperty("roles")]
        public List<HeroRole> Roles { get; set; }

        /// <summary>
        /// A hero's amount of legs
        /// </summary>
        [JsonProperty("legs")]
        public int Legs { get; set; }
    }
}
