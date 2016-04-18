using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class SystemInfoResponse
    {
        [Newtonsoft.Json.JsonProperty("Containers")]
        public long? Containers { get; set; }

        [Newtonsoft.Json.JsonProperty("Images")]
        public long? Images { get; set; }

        [Newtonsoft.Json.JsonProperty("MemoryLimit")]
        public bool? MemoryLimit { get; set; }

        [Newtonsoft.Json.JsonProperty("SwapLimit")]
        public bool? SwapLimit { get; set; }

        [Newtonsoft.Json.JsonProperty("IPv4Forwarding")]
        public bool? IPv4Forwarding { get; set; }

        [Newtonsoft.Json.JsonProperty("NFd")]
        public long? NFd { get; set; }

        [Newtonsoft.Json.JsonProperty("NGoroutines")]
        public long? NGoroutines { get; set; }

        [Newtonsoft.Json.JsonProperty("NEventsListener")]
        public long? NEventsListener { get; set; }

        [Newtonsoft.Json.JsonProperty("Sockets")]
        public IList<string> Sockets { get; set; }

        [Newtonsoft.Json.JsonProperty("KernelVersion")]
        public string KernelVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("InitPath")]
        public string InitPath { get; set; }

        [Newtonsoft.Json.JsonProperty("InitSha1")]
        public string InitSha1 { get; set; }

        [Newtonsoft.Json.JsonProperty("Driver")]
        public string Driver { get; set; }

        [Newtonsoft.Json.JsonProperty("DriverStatus")]
        public IList<IList<string>> DriverStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("ExecutionDriver")]
        public string ExecutionDriver { get; set; }

        [Newtonsoft.Json.JsonProperty("IndexServerAddress")]
        public string IndexServerAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("Debug")]
        public bool? Debug { get; set; }

        [Newtonsoft.Json.JsonProperty("NCPU")]
        public string NCPU { get;set; }

        [Newtonsoft.Json.JsonProperty("MemTotal")]
        public string MemTotal { get;set; }

        [Newtonsoft.Json.JsonProperty("ID")]
        public string ID { get;set; }

        [Newtonsoft.Json.JsonProperty("DockerRootDir")]
        public string DockerRootDir { get;set; }

        [Newtonsoft.Json.JsonProperty("OperatingSystem")]
        public string OperatingSystem { get;set; }

        [Newtonsoft.Json.JsonProperty("Labels")]
        public IList<string> Labels { get;set; }

        public SystemInfoResponse()
        {
        }
    }
}