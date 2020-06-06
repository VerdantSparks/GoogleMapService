using Newtonsoft.Json;

namespace GoogleMapService.Model.Geocoding
{
    public class Geometry : Model.Geometry
    {
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
    }
}
