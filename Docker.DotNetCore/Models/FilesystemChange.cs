using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [Newtonsoft.Json.JsonObject]
    public class FilesystemChange
    {
        public enum FilesystemChangeKind
        {
            Modify = 0,
            Add,
            Delete
        }

        [Newtonsoft.Json.JsonProperty("Path")]
        public string Path { get; set; }

        [Newtonsoft.Json.JsonProperty("Kind")]
        public FilesystemChangeKind Kind { get; set; }

        public FilesystemChange()
        {
        }
    }
}