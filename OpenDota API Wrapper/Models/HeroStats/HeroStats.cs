using Newtonsoft.Json;
using OpenDotaDotNet.Enums;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.HeroStats
{
    public class HeroStats
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }

        [JsonProperty("primary_attr")]
        public HeroPrimaryAttribute PrimaryAttr { get; set; }

        [JsonProperty("attack_type")]
        public HeroAttackType AttackType { get; set; }

        [JsonProperty("roles")]
        public List<HeroRole> Roles { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("base_health")]
        public int BaseHealth { get; set; }

        [JsonProperty("base_health_regen")]
        public double? BaseHealthRegen { get; set; }

        [JsonProperty("base_mana")]
        public int BaseMana { get; set; }

        [JsonProperty("base_mana_regen")]
        public double BaseManaRegen { get; set; }

        [JsonProperty("base_armor")]
        public double BaseArmor { get; set; }

        [JsonProperty("base_mr")]
        public int BaseMr { get; set; }

        [JsonProperty("base_attack_min")]
        public int BaseAttackMin { get; set; }

        [JsonProperty("base_attack_max")]
        public int BaseAttackMax { get; set; }

        [JsonProperty("base_str")]
        public int BaseStr { get; set; }

        [JsonProperty("base_agi")]
        public int BaseAgi { get; set; }

        [JsonProperty("base_int")]
        public int BaseInt { get; set; }

        [JsonProperty("str_gain")]
        public double StrGain { get; set; }

        [JsonProperty("agi_gain")]
        public double AgiGain { get; set; }

        [JsonProperty("int_gain")]
        public double IntGain { get; set; }

        [JsonProperty("attack_range")]
        public int AttackRange { get; set; }

        [JsonProperty("projectile_speed")]
        public int ProjectileSpeed { get; set; }

        [JsonProperty("attack_rate")]
        public double AttackRate { get; set; }

        [JsonProperty("move_speed")]
        public int MoveSpeed { get; set; }

        [JsonProperty("turn_rate")]
        public double TurnRate { get; set; }

        [JsonProperty("cm_enabled")]
        public bool CmEnabled { get; set; }

        [JsonProperty("legs")]
        public int Legs { get; set; }

        [JsonProperty("pro_ban")]
        public int ProBan { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("pro_win")]
        public int ProWin { get; set; }

        [JsonProperty("pro_pick")]
        public int ProPick { get; set; }

        [JsonProperty("1_pick")]
        public int The1_Pick { get; set; }

        [JsonProperty("1_win")]
        public int The1_Win { get; set; }

        [JsonProperty("2_pick")]
        public int The2_Pick { get; set; }

        [JsonProperty("2_win")]
        public int The2_Win { get; set; }

        [JsonProperty("3_pick")]
        public int The3_Pick { get; set; }

        [JsonProperty("3_win")]
        public int The3_Win { get; set; }

        [JsonProperty("4_pick")]
        public int The4_Pick { get; set; }

        [JsonProperty("4_win")]
        public int The4_Win { get; set; }

        [JsonProperty("5_pick")]
        public int The5_Pick { get; set; }

        [JsonProperty("5_win")]
        public int The5_Win { get; set; }

        [JsonProperty("6_pick")]
        public int The6_Pick { get; set; }

        [JsonProperty("6_win")]
        public int The6_Win { get; set; }

        [JsonProperty("7_pick")]
        public int The7_Pick { get; set; }

        [JsonProperty("7_win")]
        public int The7_Win { get; set; }

        [JsonProperty("8_pick")]
        public int The8_Pick { get; set; }

        [JsonProperty("8_win")]
        public int The8_Win { get; set; }

        [JsonProperty("null_pick")]
        public long NullPick { get; set; }

        [JsonProperty("null_win")]
        public long NullWin { get; set; }
    }
}
