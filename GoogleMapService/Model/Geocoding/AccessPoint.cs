using Newtonsoft.Json;

namespace GoogleMapService.Model.Geocoding
{
    public class AccessPoint
    {
        [JsonProperty("access_point_type")]
        public string AccessPointType { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("location_on_segment")]
        public Location LocationOnSegment { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("segment_position")]
        public double SegmentPosition { get; set; }

        [JsonProperty("unsuitable_travel_modes")]
        public object[] UnsuitableTravelModes { get; set; }
    }
}
