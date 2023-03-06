using TruckMangmentService.Helpers;
using TruckMangmentService.Models;

namespace TruckManagmentServiceTest.Helpers
{
    public class DistanceCalculatorTests
    {
        [Fact]
        public void CalculateDistanceBetweenPoints_ReturnsExpectedResult()
        {
            // Arrange
            GpsCoordinate coordinate1 = new GpsCoordinate() { Latitude = 52.516275, Longitude = 13.377704 };
            GpsCoordinate coordinate2 = new GpsCoordinate() { Latitude = 50.110924, Longitude = 8.682127 };

            // Act
            double distance = DistanceCalculator.CalculateDistanceBetweenPoints(coordinate1, coordinate2);

            // Assert
            Assert.Equal(421.8, Math.Round(distance, 1));
        }

        [Fact]
        public void CalculateDistance_ReturnsExpectedResult()
        {
            // Arrange
            List<GpsCoordinate> gpsCoordinates = new List<GpsCoordinate>()
        {
            new GpsCoordinate() { Latitude = 52.516275, Longitude = 13.377704 },
            new GpsCoordinate() { Latitude = 50.110924, Longitude = 8.682127 },
            new GpsCoordinate() { Latitude = 51.050407, Longitude = 13.737262 }
        };

            // Act
            double distance = DistanceCalculator.CalculateDistanceInKilometers(gpsCoordinates);

            // Assert
            Assert.Equal(793.6, Math.Round(distance, 1));
        }

        //TODO Add more unitTest for different case like unexpected arguments, exceptions and ...
    }
}
