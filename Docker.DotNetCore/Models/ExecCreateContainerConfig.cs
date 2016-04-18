using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    public class ExecCreateContainerConfig
    {
        [Newtonsoft.Json.JsonProperty("AttachStdin")]
        public bool? AttachStdin { get; set; }

        [Newtonsoft.Json.JsonProperty("AttachStdout")]
        public bool? AttachStdout { get; set; }

        [Newtonsoft.Json.JsonProperty("AttachStderr")]
        public bool? AttachStderr { get; set; }

        [Newtonsoft.Json.JsonProperty("Tty")]
        public bool? Tty { get; set; }

        [Newtonsoft.Json.JsonProperty("Cmd")]
        public IList<string> Cmd { get; set; }
    }
}
