using Newtonsoft.Json;

namespace GoogleMapService.Model.Place.Place
{
    public class Period
    {
        [JsonProperty("open")]
        public Open Open { get; set; }
    }
}
