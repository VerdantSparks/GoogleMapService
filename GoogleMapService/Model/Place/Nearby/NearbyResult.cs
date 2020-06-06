using Newtonsoft.Json;

namespace GoogleMapService.Model.Place.Nearby
{
    public class NearbyResult : BasePlaceResult
    {
        [JsonProperty("opening_hours")]
        public OpeningHours OpeningHours { get; set; }
    }
}
