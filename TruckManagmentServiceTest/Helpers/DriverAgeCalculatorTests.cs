
using TruckManagmentService.Helpers;

namespace TruckManagmentServiceTest.Helpers
{
    public class DriverAgeCalculatorTests
    {
        [Fact]
        public void GetDriverAge_ReturnsExpectedResult()
        {
            // Arrange
            var birthDate = new DateTime(1975, 4, 10);

            // Act
            var age = DriverAgeCalculator.GetDriverAge(new TruckMangmentService.Models.Driver { Name ="Jakob" , Birthdate = birthDate});

            // Assert
            Assert.Equal(47, age);
        }
    }
}
