using System;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class VersionResponse
    {
        [Newtonsoft.Json.JsonProperty("ApiVersion")]
        public Version ApiVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("Version")]
        public Version Version { get; set; }

        [Newtonsoft.Json.JsonProperty("GitCommit")]
        public string GitCommit { get; set; }

        [Newtonsoft.Json.JsonProperty("GoVersion")]
        public string GoVersion { get; set; }

        public VersionResponse()
        {
        }
    }
}