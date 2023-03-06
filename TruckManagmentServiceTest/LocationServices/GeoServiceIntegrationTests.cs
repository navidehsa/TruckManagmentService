using TruckManagmentService.Services;
using TruckMangmentService.Models;

namespace TruckManagmentServiceTest.LocationServices
{
    public class GeoServiceIntegrationTests
    {
        private readonly HttpClient _httpClient;
        private readonly GeoService _geoService;

        public GeoServiceIntegrationTests()
        {
            _httpClient = new HttpClient();
            _geoService = new GeoService(_httpClient);
        }

        [Fact]
        public async Task GetCountryNameAsync_ShouldReturnCountryName_WhenGivenValidGpsCoordinate()
        {
            // Arrange
            var gpsCoordinate = new GpsCoordinate { Latitude = 40.763841, Longitude = -73.972972 };

            // Act
            var result = await _geoService.GetCountryNameAsync(gpsCoordinate);

            // Assert
            Assert.Equal("United States", result);
        }
        //TODO Add more tests to see API behavior in different situtations
    }
}
