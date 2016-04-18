using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class Port
    {
        [Newtonsoft.Json.JsonProperty("Type")]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("PrivatePort")]
        public int PrivatePort { get; set; }

        [Newtonsoft.Json.JsonProperty("PublicPort")]
        public int PublicPort { get; set; }

        public Port()
        {
        }
    }
}