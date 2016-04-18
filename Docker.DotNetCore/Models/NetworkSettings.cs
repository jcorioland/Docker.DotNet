using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class NetworkSettings
    {
        [Newtonsoft.Json.JsonProperty("IPAddress")]
        public string IPAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("Gateway")]
        public string Gateway { get; set; }

        [Newtonsoft.Json.JsonProperty("Bridge")]
        public string Bridge { get; set; }

        [Newtonsoft.Json.JsonProperty("IPPrefixLen")]
        public int IPPrefixLen { get; set; }

        [Newtonsoft.Json.JsonProperty("PortMapping")]
        public IDictionary<string, IDictionary<string, string>> PortMapping { get; set; }

        [Newtonsoft.Json.JsonProperty("Ports")] public IDictionary<string, IList<PortBinding>> Ports;

        public NetworkSettings()
        {
        }
    }
}