using TruckMangmentService.Helpers;
using TruckMangmentService.Models;

namespace TruckManagmentService.Helpers
{
    /// <summary>
    /// Helper class to calculate distance for each TruckPlan
    /// </summary>
    public static class TruckPlanDistanceCalculater
    {
        public static double CalculateDistanceDriven(TruckPlan truckPlan)
        {
            // Get the GPS coordinates for the truck plan
            List<GpsCoordinate> gpsCoordinates = truckPlan.GpsCoordinates;

            // Calculate the distance driven
            double distance = DistanceCalculator.CalculateDistance(gpsCoordinates);

            return distance;
        }
    }
}
