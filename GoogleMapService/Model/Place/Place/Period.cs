using Newtonsoft.Json;

namespace LocationData.Model.Place.Place
{
    public class Period
    {
        [JsonProperty("open")]
        public Open Open { get; set; }
    }
}
