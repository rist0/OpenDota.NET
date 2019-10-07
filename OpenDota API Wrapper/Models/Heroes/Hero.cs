using Newtonsoft.Json;
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
        public PrimaryAttribute PrimaryAttribute { get; set; }

        /// <summary>
        /// Hero attack type, either 'Melee' or 'Ranged'
        /// </summary>
        [JsonProperty("attack_type")]
        public AttackType AttackType { get; set; }

        /// <summary>
        /// A hero's role in the game
        /// </summary>
        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }

        /// <summary>
        /// A hero's amount of legs
        /// </summary>
        [JsonProperty("legs")]
        public int Legs { get; set; }
    }

    public enum AttackType { Melee, Ranged };

    public enum PrimaryAttribute { Agi, Int, Str };

    public enum Role { Carry, Disabler, Durable, Escape, Initiator, Jungler, Nuker, Pusher, Support };
}
