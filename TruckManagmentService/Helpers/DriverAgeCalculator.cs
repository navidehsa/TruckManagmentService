
using TruckMangmentService.Models;

namespace TruckManagmentService.Helpers
{
    public static class DriverAgeCalculator
    {
        public static int GetDriverAge(Driver driver)
        {
            var today = DateTime.UtcNow;
            int age = today.Year - driver.Birthdate.Year;
            if (driver.Birthdate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
