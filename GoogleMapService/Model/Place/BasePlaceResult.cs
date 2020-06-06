using System;
using Newtonsoft.Json;

namespace GoogleMapService.Model.Place
{
    public abstract class BasePlaceResult : BaseActualResult
    {
        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("business_status")]
        public string BusinessStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photos")]
        public Photo[] Photos { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("user_ratings_total")]
        public long UserRatingsTotal { get; set; }

        [JsonProperty("vicinity")]
        public string Vicinity { get; set; }
    }
}
