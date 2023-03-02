using Moq;
using TruckManagmentService.Services;
using TruckManagmentService.TruckServices;
using TruckMangmentService.Models;

namespace TruckManagmentServiceTest.TruckServices
{
    public class TripServiceTests
    {
        [Fact]
        public async Task TestGetTotalDistanceDrivenByDriversOver50InGermanyInFebruary2018Async()
        {
            // Arrange
            var geoServiceMock = new Mock<IGeoService>();
            geoServiceMock
                .Setup(x => x.GetCountryNameAsync(It.IsAny<GpsCoordinate>()))
                .ReturnsAsync("Germany");

            var trips = new List<TruckPlan>
            {
                new TruckPlan
                {
                    Driver = new Driver { Birthdate = new DateTime(1968, 1, 1) },
                    StartDate = new DateTime(2018, 2, 1, 8, 0, 0),
                    EndDate = new DateTime(2018, 2, 1, 12, 0, 0),
                    GpsCoordinates = new List<GpsCoordinate>
                    {
                        new GpsCoordinate { Latitude = 52.5200, Longitude = 13.4050 },
                        new GpsCoordinate { Latitude = 51.0504, Longitude = 13.7373 },
                    },
                },
                new TruckPlan
                {
                    Driver = new Driver { Birthdate = new DateTime(1950, 1, 1) },
                    StartDate = new DateTime(2018, 2, 1, 10, 0, 0),
                    EndDate = new DateTime(2018, 2, 1, 16, 0, 0),
                    GpsCoordinates = new List<GpsCoordinate>
                    {
                        new GpsCoordinate { Latitude = 52.5200, Longitude = 13.4050 },
                        new GpsCoordinate { Latitude = 51.0504, Longitude = 13.7373 },
                        new GpsCoordinate { Latitude = 50.9375, Longitude = 6.9603 },
                    },
                },
                new TruckPlan
                {
                    Driver = new Driver { Birthdate = new DateTime(1983, 1, 1) },
                    StartDate = new DateTime(2018, 2, 15, 10, 0, 0),
                    EndDate = new DateTime(2018, 2, 15, 16, 0, 0),
                    GpsCoordinates = new List<GpsCoordinate>
                    {
                        new GpsCoordinate { Latitude = 50.1109, Longitude = 8.6821 },
                        new GpsCoordinate { Latitude = 50.9375, Longitude = 6.9603 },
                    },
                },
                new TruckPlan
                {
                    Driver = new Driver { Birthdate = new DateTime(1950, 1, 1) },
                    StartDate = new DateTime(2019, 2, 15, 10, 0, 0),
                    EndDate = new DateTime(2019, 2, 15, 16, 0, 0),
                    GpsCoordinates = new List<GpsCoordinate>
                    {
                        new GpsCoordinate { Latitude = 50.1109, Longitude = 8.6821 },
                        new GpsCoordinate { Latitude = 50.9375, Longitude = 6.9603 },
                    },
                },
            };

            var tripService = new TripService(geoServiceMock.Object);

            // Act
            var acrtual = await tripService.GetTotalDistanceDrivenByDriversOver50InGermanyInFebruary2018Async(trips);

            // Assert
            Assert.Equal(804.30, acrtual, 2);
        }
    }
}
