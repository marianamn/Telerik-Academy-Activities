using Newtonsoft.Json;

namespace ProcessingJsonInDotNET
{
    public class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
