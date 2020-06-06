using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GoogleMapService.Model;
using GoogleMapService.Model.Geocoding;
using GoogleMapService.Model.Place;
using GoogleMapService.Model.Place.Nearby;
using GoogleMapService.Model.Place.Place;
using Newtonsoft.Json;

namespace GoogleMapService
{
    public class GoogleMapService
    {
        private const string GoogleApiEndpointPrefix = "https://maps.googleapis.com/maps/api/{0}/json";
        private static readonly string GeocodeApiEndpoint = string.Format(GoogleApiEndpointPrefix, "geocode");
        private static readonly string PlaceApiEndpoint = string.Format(GoogleApiEndpointPrefix, "place/details");
        private static readonly string NearbyApiEndpoint = string.Format(GoogleApiEndpointPrefix, "place/nearbysearch");

        private readonly HttpClient _httpClient;
        private readonly string _mapApiKey;
        private readonly string _placeApiKey;

        public GoogleMapService(string mapApiKey, string placeApiKey)
        {
            _httpClient = new HttpClient();
            _mapApiKey = mapApiKey;
            _placeApiKey = placeApiKey;
        }

        /// <summary>
        /// Use this one if you use single key for all services. (Although not recommended.)
        /// </summary>
        /// <param name="apiKey"></param>
        /// <seealso>
        ///     <cref>GoogleMapService(string mapApiKey, string placeApiKey)</cref>
        /// </seealso>
        public GoogleMapService(string apiKey) : this(apiKey, apiKey) {}

        public async Task<GoogleApiQueryResult<GeocodeResult>> Geocode(string address)
        {
            var queryUrl = CreateQueryUrl(GeocodeApiEndpoint,
                                          new NameValueCollection {{"address", address}, {"key", _mapApiKey},});

            return await GetFromGoogleAsync<GoogleApiQueryResult<GeocodeResult>>(queryUrl);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="type">
        /// Using constants in PlaceTypes class will make life easier.
        /// </param>
        /// <param name="radius"></param>
        /// <param name="language"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public async Task<PlaceApiResult<NearbyResult>> Nearby(Location loc,
                                                               string type,
                                                               ushort radius = 1000,
                                                               string language = "zh-TW",
                                                               string keyword = "")
        {
            var queryUrl = CreateQueryUrl(NearbyApiEndpoint,
                                          new NameValueCollection
                                          {
                                              {"location", $"{loc.Longitude},{loc.Latitude}"},
                                              {"type", type},
                                              {"radius", radius.ToString()},
                                              {"language", language},
                                              {"keyword", keyword},
                                              {"key", _placeApiKey},
                                          });

            return await GetFromGoogleAsync<PlaceApiResult<NearbyResult>>(queryUrl);
        }

        public async Task<PlaceApiResult<PlaceResult>> Place(string placeId,
                                                             string fields = "",
                                                             string language = "zh-TW")
        {
            var queryUrl = CreateQueryUrl(PlaceApiEndpoint,
                                          new NameValueCollection
                                          {
                                              {"place_id", placeId},
                                              {"fields", fields},
                                              {"language", language},
                                              {"key", _placeApiKey},
                                          });

            return await GetFromGoogleAsync<PlaceApiResult<PlaceResult>>(queryUrl);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="apiEndpoint"></param>
        /// <param name="parameters">
        /// UrlEncode should be applied in the NameValueCollection if the value may contains malicious XSS code
        /// </param>
        /// <returns></returns>
        protected static string CreateQueryUrl(string apiEndpoint, NameValueCollection parameters)
        {
            var query = string.Join("&", parameters.AllKeys.Select(k => $"{k}={parameters[k]}"));
            var builder = new UriBuilder(string.Concat(apiEndpoint, "?", query));

            return builder.ToString();
        }

        protected async Task<T> GetFromGoogleAsync<T>(string input)
        {
            var response = await _httpClient.GetAsync(input);
            var jsonStr = await response.Content.ReadAsStringAsync();
            var baseResult = JsonConvert.DeserializeObject<T>(jsonStr);

            return baseResult;
        }
    }
}
