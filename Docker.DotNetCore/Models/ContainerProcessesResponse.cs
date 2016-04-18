using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ContainerProcessesResponse
    {
        [Newtonsoft.Json.JsonProperty("Titles")]
        public IList<string> Titles { get; set; }

        [Newtonsoft.Json.JsonProperty("Processes")]
        public IList<IList<string>> Processes { get; set; }

        public ContainerProcessesResponse()
        {
        }
    }
}