using Newtonsoft.Json;

namespace OpenDotaDotNet.Models.Request
{
    public class ParseRequest
    {
        [JsonProperty("job")]
        public Job Job { get; set; }
    }

    public partial class Job
    {
        [JsonProperty("jobId")]
        public long JobId { get; set; }
    }
}
