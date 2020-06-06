using Newtonsoft.Json;

namespace GoogleMapService.Model.Place.Nearby
{
    public class OpeningHours
    {
        [JsonProperty("open_now")]
        public bool OpenNow { get; set; }
    }
}
