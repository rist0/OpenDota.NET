using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.HealthStatus
{
    public class ServiceHealth
    {
        [JsonProperty("parseDelay")]
        public ServiceUsage ParseDelay { get; set; }

        [JsonProperty("cassandraUsage")]
        public ServiceUsage CassandraUsage { get; set; }

        [JsonProperty("redisUsage")]
        public ServiceUsage RedisUsage { get; set; }

        [JsonProperty("seqNumDelay")]
        public ServiceUsage SeqNumDelay { get; set; }

        [JsonProperty("postgresUsage")]
        public ServiceUsage PostgresUsage { get; set; }

        [JsonProperty("steamApi")]
        public ServiceUsage SteamApi { get; set; }

        [JsonProperty("gcDelay")]
        public ServiceUsage GcDelay { get; set; }
    }

    public partial class ServiceUsage
    {
        [JsonProperty("metric")]
        public double Metric { get; set; }

        [JsonProperty("threshold")]
        public long Threshold { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
