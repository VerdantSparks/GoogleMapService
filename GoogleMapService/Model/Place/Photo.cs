using Newtonsoft.Json;

namespace LocationData.Model.Place
{
    public class Photo
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("html_attributions")]
        public string[] HtmlAttributions { get; set; }

        [JsonProperty("photo_reference")]
        public string PhotoReference { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }
}
