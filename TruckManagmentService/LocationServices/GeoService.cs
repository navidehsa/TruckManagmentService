using System.Text.Json;
using TruckManagmentService.LocationServices;
using TruckMangmentService.Models;

namespace TruckManagmentService.Services
{
    public class GeoService : IGeoService
    {
        private readonly HttpClient _httpClient; 
        private const string _apiBaseUrl = "http://api.positionstack.com/v1/reverse"; //TODO move to appsettings
        private const string _accessKey = "034dbc2a96878a3dbaa4f55f29131fb5"; //TODO move to secrets

        public GeoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_apiBaseUrl);
        }
        /// <summary>
        /// Get the countryName from a coordinate.
        /// </summary>
        /// <param name="gpsCoordinate"></param>
        /// <returns>Country Name</returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<string> GetCountryNameAsync(GpsCoordinate gpsCoordinate)
        {
            var query= $"{gpsCoordinate.Latitude},{gpsCoordinate.Longitude}";
            var requestedUri = $"access_key={_accessKey}&query={query}";

            UriBuilder builder = new UriBuilder(_apiBaseUrl);
            builder.Query = requestedUri;

            var response = await _httpClient.GetAsync(builder.Uri);
            var responseString =await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var result = JsonSerializer.Deserialize<GeoServiceOutputModel>(responseString, options);
                return result.Data.First().Country;
            }
            else
            {
                throw new HttpRequestException($"Request failed with status code {response.StatusCode}");
            }
        }

    }
}
