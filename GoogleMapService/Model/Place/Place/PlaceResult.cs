using System;
using Newtonsoft.Json;

namespace GoogleMapService.Model.Place.Place
{
    public class PlaceResult : BasePlaceResult
    {
        [JsonProperty("opening_hours")]
        public OpeningHours OpeningHours { get; set; }

        [JsonProperty("adr_address")]
        public string AdrAddress { get; set; }

        [JsonProperty("formatted_phone_number")]
        public string FormattedPhoneNumber { get; set; }

        [JsonProperty("international_phone_number")]
        public string InternationalPhoneNumber { get; set; }

        [JsonProperty("reviews")]
        public Review[] Reviews { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("utc_offset")]
        public long UtcOffset { get; set; }

        [JsonProperty("website")]
        public Uri Website { get; set; }

        [JsonProperty("address_components")]
        public AddressComponent[] AddressComponents { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
    }
}
