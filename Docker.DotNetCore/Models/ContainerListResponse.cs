using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ContainerListResponse
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Names")]
        public IList<string> Names { get; set; }

        [Newtonsoft.Json.JsonProperty("Image")]
        public string Image { get; set; }

        [Newtonsoft.Json.JsonProperty("Created")]
        public DateTime Created { get; set; }

        [Newtonsoft.Json.JsonProperty("Command")]
        public string Command { get; set; }

        [Newtonsoft.Json.JsonProperty("Status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("SizeRw")]
        public long SizeRw { get; set; }

        [Newtonsoft.Json.JsonProperty("SizeRootFs")]
        public long SizeRootFs { get; set; }

        [Newtonsoft.Json.JsonProperty("Ports")]
        public IList<Port> Ports { get; set; }


        public ContainerListResponse()
        {
        }
    }
}