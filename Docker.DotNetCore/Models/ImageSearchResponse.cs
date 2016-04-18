using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ImageSearchResponse
    {
        [Newtonsoft.Json.JsonProperty("star_count")]
        public long StarCount { get; set; }

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("is_official")]
        public bool IsOfficial { get; set; }

        [Newtonsoft.Json.JsonProperty("is_trusted")]
        public bool IsTrusted { get; set; }

        public ImageSearchResponse()
        {
        }
    }
}