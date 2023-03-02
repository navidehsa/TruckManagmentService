using TruckManagmentService.Helpers;
using TruckMangmentService.Models;

namespace TruckManagmentServiceTest.Helpers
{
    public class TripDistanceCalculaterTests
    {
        [Fact]
        public void CalculateDistanceDriven_ReturnsExpectedResult()
        {
            // Arrange
            TruckPlan trip = new TruckPlan()
            {
                Driver = new Driver
                {
                    Name = "Jakob"
                },
                Truck = new Truck
                {
                    RegistrationNumber ="CS86rer"
                },
                GpsCoordinates = new List<GpsCoordinate>()
                {
                    new GpsCoordinate() { Latitude = 52.516275, Longitude = 13.377704 },
                    new GpsCoordinate() { Latitude = 50.110924, Longitude = 8.682127},
                    new GpsCoordinate() { Latitude = 51.050407, Longitude = 13.737262 }
                },
                EndDate = new DateTime(2022, 3, 1 ),
                StartDate = new DateTime(2022, 3, 1),
            };

            // Act
            double distance = TripDistanceCalculater.CalculateDistanceDriven(trip);

            // Assert
            Assert.Equal(793.6, Math.Round(distance, 1));
        }
    }
}
