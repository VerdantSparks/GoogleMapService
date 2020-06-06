using Newtonsoft.Json;

namespace GoogleMapService.Model
{
    public class Viewport
    {
        [JsonProperty("northeast")]
        public Location Northeast { get; set; }

        [JsonProperty("southwest")]
        public Location Southwest { get; set; }
    }
}
