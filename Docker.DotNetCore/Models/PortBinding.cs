using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class PortBinding
    {
        [Newtonsoft.Json.JsonProperty("HostIp")]
        public string HostIp { get; set; }

        [Newtonsoft.Json.JsonProperty("HostPort")]
        public string HostPort { get; set; }

        public PortBinding()
        {
        }
    }
}