using Newtonsoft.Json;

namespace LocationData.Model.Geocoding
{
    public class Geometry : Model.Geometry
    {
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
    }
}
