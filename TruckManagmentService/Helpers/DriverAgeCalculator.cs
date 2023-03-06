
using TruckMangmentService.Models;

namespace TruckManagmentService.Helpers
{
    /// <summary>
    /// Helper class to calculate age 
    /// </summary>
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
