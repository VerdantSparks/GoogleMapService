using Newtonsoft.Json;

namespace LocationData.Model.Place.Nearby
{
    public class NearbyResult : BasePlaceResult
    {
        [JsonProperty("opening_hours")]
        public OpeningHours OpeningHours { get; set; }
    }
}
