using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ImageHistoryResponse
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Created")]
        public DateTime Created { get; set; }

        [Newtonsoft.Json.JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("Size")]
        public long Size { get; set; }

        [Newtonsoft.Json.JsonProperty("Tags")]
        public IList<string> Tags { get; set; }

        public ImageHistoryResponse()
        {
        }
    }
}