using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    public enum RestartPolicyKind
    {
        [Newtonsoft.Json.JsonProperty("")]
        Undefined,

        [Newtonsoft.Json.JsonProperty("no")]
        No,

        [Newtonsoft.Json.JsonProperty("always")]
        Always,

        [Newtonsoft.Json.JsonProperty("on-failure")]
        OnFailure,

        [Newtonsoft.Json.JsonProperty("unless-stopped")]
        UnlessStopped
    }

    [Newtonsoft.Json.JsonObject]
    public class RestartPolicy
    {
        [Newtonsoft.Json.JsonProperty("Name")]
        public RestartPolicyKind Name { get; set; }

        [Newtonsoft.Json.JsonProperty("MaximumRetryCount")]
        public int MaximumRetryCount { get; set; }
    }
}