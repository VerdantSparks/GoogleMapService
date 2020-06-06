using Newtonsoft.Json;

namespace GoogleMapService.Model
{
    public class Geometry
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("viewport")]
        public Viewport Viewport { get; set; }
    }
}
