using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class WaitContainerResponse
    {
        [Newtonsoft.Json.JsonProperty("StatusCode")] public int StatusCode;

        public WaitContainerResponse()
        {
        }
    }
}