using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class HostConfig
    {
        [Newtonsoft.Json.JsonProperty("Binds")]
        public IList<string> Binds { get; set; }

        [Newtonsoft.Json.JsonProperty("Links")]
        public IList<string> Links { get; set; }

        [Newtonsoft.Json.JsonProperty("GroupAdd")]
        public IList<string> GroupAdd { get; set; }

        [Newtonsoft.Json.JsonProperty("ContainerIDFile")]
        public string ContainerIdFile { get; set; }

        [Newtonsoft.Json.JsonProperty("Privileged")]
        public bool Privileged { get; set; }

        [Newtonsoft.Json.JsonProperty("PortBindings")] public IDictionary<string, IList<PortBinding>> PortBindings;

        [Newtonsoft.Json.JsonProperty("PublishAllPorts")]
        public bool PublishAllPorts { get; set; }

        [Newtonsoft.Json.JsonProperty("Dns")]
        public IList<string> Dns { get; set; }

        [Newtonsoft.Json.JsonProperty("DnsSearch")]
        public IList<string> DnsSearch { get; set; }

        [Newtonsoft.Json.JsonProperty("VolumesFrom")]
        public IList<string> VolumesFrom { get; set; }

        [Newtonsoft.Json.JsonProperty("RestartPolicy")]
        public RestartPolicy RestartPolicy { get; set; }

        [Newtonsoft.Json.JsonProperty("NetworkMode")]
        public string NetworkMode { get;set; }

        [Newtonsoft.Json.JsonProperty("CapAdd")]
        public IList<string> CapAdd { get;set; }

        [Newtonsoft.Json.JsonProperty("CapDrop")]
        public IList<string> CapDrop { get;set; }

        // Commenting out LxcConf parameter because its type in the request
        // form and response form are not the same. (one example says it's [], another
        // example says it's {"key": "value"}, API is totally messed up with such inconsistencies.
        // In order to make methods using this HostConfig type to work, commenting this out.
        //[Newtonsoft.Json.JsonProperty("LxcConf")]
        //public IDictionary<string, string> LxcConf { get; set; }

        public HostConfig()
        {
        }
    }
}