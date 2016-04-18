using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ContainerResponse
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Created")]
        public DateTime Created { get; set; }

        [Newtonsoft.Json.JsonProperty("Config")]
        public Config Config { get; set; }

        [Newtonsoft.Json.JsonProperty("Parent")]
        public string Parent { get; set; }

        [Newtonsoft.Json.JsonProperty("Path")]
        public string Path { get; set; }

        [Newtonsoft.Json.JsonProperty("ProcessLabel")]
        public string ProcessLabel { get; set; }

        [Newtonsoft.Json.JsonProperty("Driver")]
        public string Driver { get; set; }

        [Newtonsoft.Json.JsonProperty("ExecDriver")]
        public string ExecDriver { get; set; }

        [Newtonsoft.Json.JsonProperty("MountLabel")]
        public string MountLabel { get; set; }

        [Newtonsoft.Json.JsonProperty("HostsPath")]
        public string HostsPath { get; set; }

        [Newtonsoft.Json.JsonProperty("HostnamePath")]
        public string HostnamePath { get; set; }

        [Newtonsoft.Json.JsonProperty("Args")]
        public IList<string> Args { get; set; }

        [Newtonsoft.Json.JsonProperty("Image")]
        public string Image { get; set; }

        [Newtonsoft.Json.JsonProperty("State")]
        public ContainerState State { get; set; }

        [Newtonsoft.Json.JsonProperty("NetworkSettings")]
        public NetworkSettings NetworkSettings { get; set; }

        [Newtonsoft.Json.JsonProperty("SysInitPath")]
        public string SysInitPath { get; set; }

        [Newtonsoft.Json.JsonProperty("ResolvConfPath")]
        public string ResolvConfPath { get; set; }

        [Newtonsoft.Json.JsonProperty("HostConfig")]
        public HostConfig HostConfig { get; set; }

        [Newtonsoft.Json.JsonProperty("Volumes")]
        public IDictionary<string, string> Volumes { get; set; }

        [Newtonsoft.Json.JsonProperty("VolumesRW")]
        public IDictionary<string, bool> VolumesRW { get; set; }

        public ContainerResponse()
        {
        }
    }
}