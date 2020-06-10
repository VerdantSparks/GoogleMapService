using Newtonsoft.Json;

namespace LocationData.Model
{
    public class GoogleApiQueryResult<T>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("results")]
        public T[] Results { get; set; }

        [JsonProperty("result")]
        private T Result
        {
            set { Results ??= new[] {value}; }
        }
    }
}
