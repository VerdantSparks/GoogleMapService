using Newtonsoft.Json;

namespace LocationData.Model.Place.Nearby
{
    public class OpeningHours
    {
        [JsonProperty("open_now")]
        public bool OpenNow { get; set; }
    }
}
