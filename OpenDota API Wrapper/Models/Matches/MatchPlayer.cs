using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Matches
{
    public class MatchPlayer
    {
        // Match ID
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonProperty("player_slot")]
        public int PlayerSlot { get; set; }

        // TODO: Check if this actually works???
        // Object containing information on who the player used their abilities on
        [JsonProperty("ability_targets")]
        public Dictionary<string, Dictionary<string, int>> AbilityTargets { get; set; }

        // An array describing how abilities were upgraded
        [JsonProperty("ability_upgrades_arr")]
        public List<int> AbilityUpgradesArr { get; set; }

        // Object containing information on how many times the played used their abilities
        [JsonProperty("ability_uses")]
        public Dictionary<string, int> AbilityUses { get; set; }

        // Account ID
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        // Object containing information on how many and what type of actions the player issued to their hero
        [JsonProperty("actions")]
        public Dictionary<string, long> Actions { get; set; }

        // Object containing information on additional units the player had under their control
        [JsonProperty("additional_units")]
        public List<AdditionalUnit> AdditionalUnits { get; set; }

        // Number of assists the player had
        [JsonProperty("assists")]
        public long Assists { get; set; }

        // Item in backpack slot 0
        [JsonProperty("backpack_0")]
        public long Backpack0 { get; set; }

        // Item in backpack slot 1
        [JsonProperty("backpack_1")]
        public long Backpack1 { get; set; }

        // Item in backpack slot 2
        [JsonProperty("backpack_2")]
        public long Backpack2 { get; set; }

        // Array containing information about buybacks
        [JsonProperty("buyback_log")]
        public List<BuybackLog> BuybackLogs { get; set; }

        // Number of camps stacked
        [JsonProperty("camps_stacked")]
        public int? CampsStacked { get; set; }

        [JsonProperty("connection_log")]
        public List<ConnectionLog> ConnectionLog { get; set; }

        // Number of creeps stacked
        [JsonProperty("creeps_stacked")]
        public int? CreepsStacked { get; set; }

        // Object containing information about damage dealt by the player to different units <unit,damage>
        [JsonProperty("damage")]
        public Dictionary<string, long> Damage { get; set; }

        // Object containing information about about the sources of this player's damage to heroes
        [JsonProperty("damage_inflictor")]
        public Dictionary<string, int> DamageInflictor { get; set; }

        // Object containing information about the sources of damage received by this player from heroes
        [JsonProperty("damage_inflictor_received")]
        public Dictionary<string, int> DamageInflictorReceived { get; set; }

        // Object containing information about from whom the player took damage
        [JsonProperty("damage_taken")]
        public Dictionary<string, int> DamageTaken { get; set; }

        // Object containing information on how and how much damage the player dealt to other heroes
        [JsonProperty("damage_targets")]
        public Dictionary<string, Dictionary<string, int>> DamageTargets { get; set; }

        // Number of deaths
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        // Number of denies
        [JsonProperty("denies")]
        public int Denies { get; set; }

        // Array containing number of denies at different times of the match
        [JsonProperty("dn_t")]
        public List<int> DeniesAtDifferentTimes { get; set; }

        // Indicates whether the player claimed first blood or not [might not be a bool?]
        [JsonProperty("firstblood_claimed")]
        public bool? FirstbloodClaimed { get; set; }

        // Gold at the end of the game
        [JsonProperty("gold")]
        public int Gold { get; set; }

        // Gold Per Minute obtained by this player
        [JsonProperty("gold_per_min")]
        public int GoldPerMin { get; set; }

        // Object containing information on how the player gainined gold over the course of the match
        [JsonProperty("gold_reasons")]
        public Dictionary<string, int> GoldReasons { get; set; }

        // How much gold the player spent
        [JsonProperty("gold_spent")]
        public int GoldSpent { get; set; }

        // Array containing total gold at different times of the match
        [JsonProperty("gold_t")]
        public List<long> GoldEachMinute { get; set; }

        // Hero Damage Dealt
        [JsonProperty("hero_damage")]
        public long HeroDamage { get; set; }

        // Hero Healing Done
        [JsonProperty("hero_healing")]
        public long HeroHealing { get; set; }

        // Object containing information on how many ticks of damages the hero inflicted with different spells and damage inflictors
        [JsonProperty("hero_hits")]
        public Dictionary<string, int> HeroHits { get; set; }

        // The ID value of the hero played
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        // Item in the player's first slot
        [JsonProperty("item_0")]
        public long Item0 { get; set; }

        // Item in the player's second slot
        [JsonProperty("item_1")]
        public long Item1 { get; set; }

        // Item in the player's third slot
        [JsonProperty("item_2")]
        public long Item2 { get; set; }

        // Item in the player's fourth slot
        [JsonProperty("item_3")]
        public long Item3 { get; set; }

        // Item in the player's fifth slot
        [JsonProperty("item_4")]
        public long Item4 { get; set; }

        // Item in the player's sixth slot
        [JsonProperty("item_5")]
        public long Item5 { get; set; }

        // Object containing information about how many times a player used items
        [JsonProperty("item_uses")]
        public Dictionary<string, int> ItemUses { get; set; }

        // Object containing information about the player's killstreaks
        [JsonProperty("kill_streaks")]
        public Dictionary<string, int> KillStreaks { get; set; }

        // Object containing information about what units the player killed
        [JsonProperty("killed")]
        public Dictionary<string, int> UnitsKilled { get; set; }

        // Object containing information about who killed the player
        [JsonProperty("killed_by")]
        public Dictionary<string, int> KilledBy { get; set; }

        // Number of kills
        [JsonProperty("kills")]
        public long Kills { get; set; }

        // Array containing information on which hero the player killed at what time
        [JsonProperty("kills_log")]
        public List<KillLog> KillsLog { get; set; }

        // Object containing information on lane position
        [JsonProperty("lane_pos")]
        public Dictionary<string, Dictionary<string, int>> LanePos { get; set; }

        // Number of last hits
        [JsonProperty("last_hits")]
        public int LastHits { get; set; }

        // Integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned
        [JsonProperty("leaver_status")]
        public int LeaverStatus { get; set; }

        // Level at the end of the game
        [JsonProperty("level")]
        public int Level { get; set; }

        // Array describing last hits at each minute in the game
        [JsonProperty("lh_t")]
        public List<int> LastHitsEachMinute { get; set; }

        [JsonProperty("life_state")]
        public Dictionary<string, long> LifeState { get; set; }

        // Object with information on the highest damage instance the player inflicted
        [JsonProperty("max_hero_hit")]
        public MaxHeroHit MaxHeroHit { get; set; }

        // Object with information on the number of the number of multikills the player had
        [JsonProperty("multi_kills")]
        public Dictionary<string, int> MultiKills { get; set; }

        // Object with information on where the player placed observer wards. The location takes the form (outer number, inner number) and are from ~64-192.
        [JsonProperty("obs")]
        public Dictionary<string, Dictionary<string, int>> Obs { get; set; }

        [JsonProperty("obs_left_log")]
        public List<WardLog> ObsLeftLog { get; set; }

        // Object containing information on when and where the player placed observer wards
        [JsonProperty("obs_log")]
        public List<WardLog> ObsLog { get; set; }

        // Total number of observer wards placed
        [JsonProperty("obs_placed")]
        public int? ObsPlaced { get; set; }

        [JsonProperty("party_id")]
        public int PartyId { get; set; }

        // Size of the players party. If not in a party, will return 1.
        [JsonProperty("party_size")]
        public int PartySize { get; set; }

        // ???
        // [JsonProperty("performance_others")]
        // public object PerformanceOthers { get; set; }

        // Array describing permanent buffs the player had at the end of the game. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/permanent_buffs.json
        [JsonProperty("permanent_buffs")]
        public List<PermanentBuff> PermanentBuffs { get; set; }

        // Total number of pings
        [JsonProperty("pings")]
        public int? Pings { get; set; }

        // Whether the player predicted victory
        [JsonProperty("pred_vict")]
        public bool? PredVict { get; set; }

        // Object containing information on the items the player purchased (item, times purchased)
        [JsonProperty("purchase")]
        public Dictionary<string, long?> Purchase { get; set; }

        // Object containing information on when items were purchased
        [JsonProperty("purchase_log")]
        public List<PurchaseLog> PurchaseLog { get; set; }

        // Whether the player randomed or not
        [JsonProperty("randomed")]
        public bool? Randomed { get; set; }

        // Whether the player repicked or not (no longer a thing?)
        [JsonProperty("repicked")]
        public bool? Repicked { get; set; }

        // Total number of roshan kills (last hit on roshan) the player had
        [JsonProperty("roshans_killed")]
        public int? RoshansKilled { get; set; }

        // Number of runes picked up
        [JsonProperty("rune_pickups")]
        public int? RunePickups { get; set; }

        // Object with information about which runes the player picked up
        [JsonProperty("runes")]
        public Dictionary<string, int> Runes { get; set; }

        // List with information on when runes were picked up
        [JsonProperty("runes_log")]
        public List<RuneLog> RuneLogs { get; set; }

        // Object with information on where sentries were placed. The location takes the form (outer number, inner number) and are from ~64-192.
        [JsonProperty("sen")]
        public Dictionary<string, Dictionary<string, int>> Sen { get; set; }

        // Array containing information on when and where the player placed sentries
        [JsonProperty("sen_left_log")]
        public List<WardLog> SenLeftLog { get; set; }

        // Array with information on when and where sentries were placed by the player
        [JsonProperty("sen_log")]
        public List<WardLog> SenLog { get; set; }

        // How many sentries were placed by the player
        [JsonProperty("sen_placed")]
        public int? SenPlaced { get; set; }

        // Total stun duration of all stuns by the player
        [JsonProperty("stuns")]
        public double? Stuns { get; set; }

        // Percentage of total teamfight participation by the player (value between 0-1)
        [JsonProperty("teamfight_participation")]
        public double? TeamfightParticipation { get; set; }

        // Time in seconds corresponding to the time of entries of other arrays in the match.
        [JsonProperty("times")]
        public List<int> Times { get; set; }

        // Total tower damage done by the player
        [JsonProperty("tower_damage")]
        public int TowerDamage { get; set; }

        // Total number of tower kills (last hit on tower) the player had
        [JsonProperty("towers_killed")]
        public int? TowersKilled { get; set; }

        // Experience Per Minute obtained by the player
        [JsonProperty("xp_per_min")]
        public int XpPerMin { get; set; }

        // Object containing information on the sources of this player's experience
        [JsonProperty("xp_reasons")]
        public Dictionary<string, int> XpReasons { get; set; }

        // Experience at each minute of the game
        [JsonProperty("xp_t")]
        public List<long> XpEachMinute { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        // Time in seconds of last login of the player
        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        // Boolean indicating whether Radiant won the match
        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        // Start time of the match in seconds since 1970
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        // Duration of the game in seconds
        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        // Integer corresponding to lobby type of match. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json
        [JsonProperty("lobby_type")]
        public int LobbyType { get; set; }

        // Integer corresponding to game mode played. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json
        [JsonProperty("game_mode")]
        public int GameMode { get; set; }

        // Whether the player is a contributor to OpenDota or not
        [JsonProperty("is_contributor")]
        public bool IsContributor { get; set; }

        // Integer representing the patch the game was played on
        [JsonProperty("patch")]
        public long Patch { get; set; }

        // Boolean for whether or not the player is on Radiant
        [JsonProperty("isRadiant")]
        public bool IsRadiant { get; set; }

        // Binary integer representing whether or not the player won
        [JsonProperty("win")]
        public int Win { get; set; }

        // Binary integer representing whether or not the player lost
        [JsonProperty("lose")]
        public int Lose { get; set; }

        // Total gold at the end of the game
        [JsonProperty("total_gold")]
        public long TotalGold { get; set; }

        // Total experience at the end of the game
        [JsonProperty("total_xp")]
        public long TotalXp { get; set; }

        // Number of kills per minute
        [JsonProperty("kills_per_min")]
        public double KillsPerMin { get; set; }

        // Kills deaths assists ratio (K+A)/D
        [JsonProperty("kda")]
        public long Kda { get; set; }

        // Abandons
        [JsonProperty("abandons")]
        public int Abandons { get; set; }

        // Total number of neutral creeps killed
        [JsonProperty("neutral_kills")]
        public int NeutralKills { get; set; }

        // Total number of tower kills the player had
        [JsonProperty("tower_kills")]
        public int TowerKills { get; set; }

        // Total number of courier kills the player had
        [JsonProperty("courier_kills")]
        public int CourierKills { get; set; }

        // Total number of lane creeps killed by the player
        [JsonProperty("lane_kills")]
        public int LaneKills { get; set; }

        // Total number of heroes killed by the player
        [JsonProperty("hero_kills")]
        public int HeroKills { get; set; }

        // Total number of observer wards killed by the player
        [JsonProperty("observer_kills")]
        public int ObserverKills { get; set; }

        // Total number of sentry wards killed by the player
        [JsonProperty("sentry_kills")]
        public int SentryKills { get; set; }

        // Total number of roshan kills (last hit on roshan) the player had
        [JsonProperty("roshan_kills")]
        public int RoshanKills { get; set; }

        // Total number of Necronomicon creeps killed by the player
        [JsonProperty("necronomicon_kills")]
        public int NecronomiconKills { get; set; }

        // Total number of Ancient creeps killed by the player
        [JsonProperty("ancient_kills")]
        public int AncientKills { get; set; }

        // Total number of buyback the player used
        [JsonProperty("buyback_count")]
        public int BuybackCount { get; set; }

        // Number of observer wards used
        [JsonProperty("observer_uses")]
        public int ObserverUses { get; set; }

        // Number of sentry wards used
        [JsonProperty("sentry_uses")]
        public int SentryUses { get; set; }

        // Lane efficiency of the player (value between 0-1)
        [JsonProperty("lane_efficiency")]
        public double LaneEfficiency { get; set; }

        // Percentage of lane efficiency (0-100)
        [JsonProperty("lane_efficiency_pct")]
        public int LaneEfficiencyPct { get; set; }

        // Integer referring to which lane the hero laned in
        [JsonProperty("lane")]
        public int Lane { get; set; }

        // Lane role
        [JsonProperty("lane_role")]
        public int LaneRole { get; set; }

        // Boolean referring to whether or not the player roamed
        [JsonProperty("is_roaming")]
        public bool IsRoaming { get; set; }

        // Object with information on when the player last purchased an item
        [JsonProperty("purchase_time")]
        public Dictionary<string, int?> PurchaseTime { get; set; }

        // Object with information on when the player first puchased an item
        [JsonProperty("first_purchase_time")]
        public Dictionary<string, int?> FirstPurchaseTime { get; set; }

        // Object with information on whether or not the item won
        [JsonProperty("item_win")]
        public Dictionary<string, int?> ItemWin { get; set; }

        // Object containing binary integers that tell whether the item was purchased by the player (note: this is always 1)
        [JsonProperty("item_usage")]
        public Dictionary<string, int?> ItemUsage { get; set; }

        // Total number of TP scrolls purchased by the player
        [JsonProperty("purchase_tpscroll")]
        public int PurchaseTpscroll { get; set; }

        // Actions per minute
        [JsonProperty("actions_per_min")]
        public int ActionsPerMin { get; set; }

        [JsonProperty("life_state_dead")]
        public int LifeStateDead { get; set; }

        // The rank tier of the player. Tens place indicates rank, ones place indicates stars.
        [JsonProperty("rank_tier")]
        public int? RankTier { get; set; }

        // Cosmetics
        [JsonProperty("cosmetics")]
        public List<Cosmetic> Cosmetics { get; set; }

        // Object containing information on certain benchmarks like GPM, XPM, KDA, tower damage, etc
        [JsonProperty("benchmarks")]
        public MatchPlayerBenchmarks Benchmarks { get; set; }

        // Total amount of observer wards purchased by the player
        [JsonProperty("purchase_ward_observer", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurchaseWardObserver { get; set; }

        // Total amount of sentry wards purchased by the player
        [JsonProperty("purchase_ward_sentry", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurchaseWardSentry { get; set; }

        // Total amount of gems purchased by the player
        [JsonProperty("purchase_gem", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurchaseGem { get; set; }
    }
}
