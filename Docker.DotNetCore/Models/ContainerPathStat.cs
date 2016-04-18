using System;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ContainerPathStat
    {
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Size")]
        public int Size { get; set; }

        [Newtonsoft.Json.JsonProperty("Mode")]
        public int Mode { get; set; }

        [Newtonsoft.Json.JsonProperty("MTime")]
        public DateTime ModifiedTime { get; set; }

        [Newtonsoft.Json.JsonProperty("LinkTarget")]
        public string LinkTarget { get; set; } 
    }
}
