using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ImageListResponse
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("ParentId")]
        public string ParentId { get; set; }

        [Newtonsoft.Json.JsonProperty("RepoTags")]
        public IList<string> RepoTags { get; set; }

        [Newtonsoft.Json.JsonProperty("Created")]
        public DateTime Created { get; set; }

        [Newtonsoft.Json.JsonProperty("Size")]
        public long Size { get; set; }

        [Newtonsoft.Json.JsonProperty("VirtualSize")]
        public long VirtualSize { get; set; }

        public ImageListResponse()
        {
        }
    }
}