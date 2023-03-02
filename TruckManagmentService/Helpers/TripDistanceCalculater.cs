using TruckMangmentService.Helpers;
using TruckMangmentService.Models;

namespace TruckManagmentService.Helpers
{
    /// <summary>
    /// Helper class to calculate distance for each trip
    /// </summary>
    public static class TripDistanceCalculater
    {
        public static double CalculateDistanceDriven(TruckPlan trip)
        {
            // Get the GPS coordinates for the truck plan
            List<GpsCoordinate> gpsCoordinates = trip.GpsCoordinates;

            // Calculate the distance driven
            double distance = DistanceCalculator.CalculateDistanceInKilometers(gpsCoordinates);

            return distance;
        }
    }
}
