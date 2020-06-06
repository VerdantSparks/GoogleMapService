using System;
using Newtonsoft.Json;

namespace GoogleMapService.Model.Place.Place
{
    public class Review
    {
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_url")]
        public Uri AuthorUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("profile_photo_url")]
        public Uri ProfilePhotoUrl { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("relative_time_description")]
        public string RelativeTimeDescription { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
