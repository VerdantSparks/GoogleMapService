using Newtonsoft.Json;

namespace LocationData.Model.Place
{
    public class PlaceApiResult<T> : GoogleApiQueryResult<T>
    {
        [JsonProperty("html_attributions")]
        public object[] HtmlAttributions { get; set; }
    }
}
