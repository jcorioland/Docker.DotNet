using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class CommitContainerChangesResponse
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        public CommitContainerChangesResponse()
        {
        }
    }
}