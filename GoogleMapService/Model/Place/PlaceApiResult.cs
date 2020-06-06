using Newtonsoft.Json;

namespace GoogleMapService.Model.Place
{
    public class PlaceApiResult<T> : GoogleApiQueryResult<T>
    {
        [JsonProperty("html_attributions")]
        public object[] HtmlAttributions { get; set; }
    }
}
