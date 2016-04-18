using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class CopyFromContainerParameters
    {
        [Newtonsoft.Json.JsonProperty("Resource")]
        public string Resource { get; set; }

        public CopyFromContainerParameters()
        {
        }
    }
}