using Newtonsoft.Json;

namespace GoogleMapService.Model.Place.Place
{
    public class OpeningHours : Nearby.OpeningHours
    {
        [JsonProperty("periods")]
        public Period[] Periods { get; set; }

        [JsonProperty("weekday_text")]
        public string[] WeekdayText { get; set; }
    }
}
