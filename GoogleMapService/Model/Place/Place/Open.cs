using Newtonsoft.Json;

namespace LocationData.Model.Place.Place
{
    public class Open
    {
        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
