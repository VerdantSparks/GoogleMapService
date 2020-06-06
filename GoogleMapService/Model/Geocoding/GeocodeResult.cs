using Newtonsoft.Json;

namespace GoogleMapService.Model.Geocoding
{
    public class GeocodeResult : BaseActualResult
    {
        [JsonProperty("access_points")]
        public AccessPoint[] AccessPoints { get; set; }

        [JsonProperty("address_components")]
        public AddressComponent[] AddressComponents { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
    }
}
