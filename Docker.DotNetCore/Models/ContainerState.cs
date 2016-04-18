using System;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ContainerState
    {
        [Newtonsoft.Json.JsonProperty("StartedAt")]
        public DateTime? StartedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("FinishedAt")]
        public DateTime? FinishedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("Running")]
        public bool? Running { get; set; }

        [Newtonsoft.Json.JsonProperty("Paused")]
        public bool? Paused { get; set; }

        [Newtonsoft.Json.JsonProperty("Pid")]
        public int? Pid { get; set; }

        [Newtonsoft.Json.JsonProperty("ExitCode")]
        public int? ExitCode { get; set; }

        public ContainerState()
        {
        }
    }
}