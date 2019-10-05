using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenDotaDotNet.Models.Matches
{
    public class KillLog
    {
        // The unit who got killed
        [JsonProperty("key")]
        public string Key { get; set; }

        // Time in seconds when the kill happened
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
