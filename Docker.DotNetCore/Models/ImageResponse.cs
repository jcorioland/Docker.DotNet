using System;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class ImageResponse
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Parent")]
        public string Parent { get; set; }

        [Newtonsoft.Json.JsonProperty("Container")]
        public string Container { get; set; }

        [Newtonsoft.Json.JsonProperty("Author")]
        public string Author { get; set; }

        [Newtonsoft.Json.JsonProperty("Comment")]
        public string Comment { get; set; }

        [Newtonsoft.Json.JsonProperty("Os")]
        public string Os { get; set; }

        [Newtonsoft.Json.JsonProperty("Size")]
        public long Size { get; set; }

        [Newtonsoft.Json.JsonProperty("Architecture")]
        public string Architecture { get; set; }

        [Newtonsoft.Json.JsonProperty("Created")]
        public DateTime Created { get; set; }

        [Newtonsoft.Json.JsonProperty("DockerVersion")]
        public string DockerVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("Config")]
        public Config Config { get; set; }

        [Newtonsoft.Json.JsonProperty("ContainerConfig")]
        public Config ContainerConfig { get; set; }

        public ImageResponse()
        {
        }
    }
}