using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenDotaDotNet.Models.Players
{
    public class PlayerWardmap
    {
        [JsonProperty("obs")]
        public Dictionary<string, Dictionary<string, long>> Obs { get; set; }

        [JsonProperty("sen")]
        public Dictionary<string, Dictionary<string, long>> Sen { get; set; }
    }
}
