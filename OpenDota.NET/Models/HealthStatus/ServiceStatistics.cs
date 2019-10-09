using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.HealthStatus
{
    public class ServiceStatistics
    {
        [JsonProperty("user_players")]
        public int UserPlayers { get; set; }

        [JsonProperty("tracked_players")]
        public int TrackedPlayers { get; set; }

        [JsonProperty("matches_last_day")]
        public int MatchesLastDay { get; set; }

        [JsonProperty("matches_last_hour")]
        public int MatchesLastHour { get; set; }

        [JsonProperty("retriever_matches_last_day")]
        public int RetrieverMatchesLastDay { get; set; }

        [JsonProperty("backup_retriever_last_day")]
        public int BackupRetrieverLastDay { get; set; }

        [JsonProperty("parsed_matches_last_day")]
        public int ParsedMatchesLastDay { get; set; }

        [JsonProperty("requests_last_day")]
        public int RequestsLastDay { get; set; }

        [JsonProperty("fullhistory_last_day")]
        public int FullhistoryLastDay { get; set; }

        [JsonProperty("webhooks_last_day")]
        public int WebhooksLastDay { get; set; }

        [JsonProperty("feed_last_day")]
        public int FeedLastDay { get; set; }

        [JsonProperty("api_hits_last_day")]
        public int ApiHitsLastDay { get; set; }

        [JsonProperty("api_hits_ui_last_day")]
        public int ApiHitsUiLastDay { get; set; }

        [JsonProperty("fhQueue")]
        public int FhQueue { get; set; }

        [JsonProperty("gcQueue")]
        public int GcQueue { get; set; }

        [JsonProperty("mmrQueue")]
        public int MmrQueue { get; set; }

        [JsonProperty("countsQueue")]
        public int CountsQueue { get; set; }

        [JsonProperty("scenariosQueue")]
        public int ScenariosQueue { get; set; }

        [JsonProperty("benchmarksQueue")]
        public int BenchmarksQueue { get; set; }

        [JsonProperty("retriever")]
        public List<ApiPath> Retriever { get; set; }

        [JsonProperty("api_paths")]
        public List<ApiPath> ApiPaths { get; set; }

        [JsonProperty("last_added")]
        public List<Last> LastAdded { get; set; }

        [JsonProperty("last_parsed")]
        public List<Last> LastParsed { get; set; }

        [JsonProperty("load_times")]
        public Dictionary<string, long> LoadTimes { get; set; }

        [JsonProperty("health")]
        public ServiceHealth Health { get; set; }
    }

    public partial class ApiPath
    {
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }

    public partial class Last
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }
    }
}
