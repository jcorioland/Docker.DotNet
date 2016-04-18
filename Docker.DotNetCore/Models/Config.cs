using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class Config
    {
        [Newtonsoft.Json.JsonProperty("Hostname")]
        public string Hostname { get; set; }

        [Newtonsoft.Json.JsonProperty("Domainname")]
        public string DomainName { get; set; }

        [Newtonsoft.Json.JsonProperty("Image")]
        public string Image { get; set; }

        [Newtonsoft.Json.JsonProperty("User")]
        public string User { get; set; }

        [Newtonsoft.Json.JsonProperty("Memory")]
        public long Memory { get; set; }

        [Newtonsoft.Json.JsonProperty("MemorySwap")]
        public long MemorySwap { get; set; }

        [Newtonsoft.Json.JsonProperty("CpuShares")]
        public long CpuShares { get; set; }

        [Newtonsoft.Json.JsonProperty("CpuSet")]
        public string CpuSet { get; set; }

        [Newtonsoft.Json.JsonProperty("AttachStdin")]
        public bool AttachStdin { get; set; }

        [Newtonsoft.Json.JsonProperty("AttachStdout")]
        public bool AttachStdout { get; set; }

        [Newtonsoft.Json.JsonProperty("AttachStderr")]
        public bool AttachStderr { get; set; }

        [Newtonsoft.Json.JsonProperty("PortSpecs")]
        public IList<string> PortSpecs { get; set; }

        [Newtonsoft.Json.JsonProperty("Tty")]
        public bool Tty { get; set; }

        [Newtonsoft.Json.JsonProperty("OpenStdin")]
        public bool OpenStdin { get; set; }

        [Newtonsoft.Json.JsonProperty("StdinOnce")]
        public bool StdinOnce { get; set; }

        [Newtonsoft.Json.JsonProperty("Env")]
        public IList<string> Env { get; set; }

        [Newtonsoft.Json.JsonProperty("Cmd")]
        public IList<string> Cmd { get; set; }

        [Newtonsoft.Json.JsonProperty("Entrypoint")]
        public IList<string> Entrypoint { get; set; }

        [Newtonsoft.Json.JsonProperty("OnBuild")]
        public IList<string> OnBuild { get; set; }

        [Newtonsoft.Json.JsonProperty("Dns")]
        public IList<string> Dns { get; set; }

        [Newtonsoft.Json.JsonProperty("WorkingDir")]
        public string WorkingDir { get; set; }

        [Newtonsoft.Json.JsonProperty("NetworkDisabled")]
        public bool NetworkDisabled { get; set; }

        [Newtonsoft.Json.JsonProperty("VolumesFrom")]
        public string VolumesFrom { get; set; }

        [Newtonsoft.Json.JsonProperty("Volumes")]
        public IDictionary<string, object> Volumes { get; set; }

        [Newtonsoft.Json.JsonProperty("ExposedPorts")]
        public IDictionary<string, object> ExposedPorts { get; set; }

        [Newtonsoft.Json.JsonProperty("HostConfig")]
        public HostConfig HostConfig { get; set; }

        [Newtonsoft.Json.JsonProperty("MacAddress")]
        public string MacAddress { get;set; }

        public Config()
        {
        }
    }
}