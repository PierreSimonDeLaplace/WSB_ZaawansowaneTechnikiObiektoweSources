using Newtonsoft.Json;

namespace RefactorExample.DTOs
{
    public class Play
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}