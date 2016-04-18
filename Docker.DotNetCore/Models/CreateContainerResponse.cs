using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class CreateContainerResponse
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Warnings")]
        public IList<string> Warnings { get; set; }

        public CreateContainerResponse()
        {
        }
    }
}