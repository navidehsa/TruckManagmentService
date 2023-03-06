using TruckMangmentService.Models;

namespace TruckMangmentService.Helpers
{
    /// <summary>
    /// Helper class to calculate distance 
    /// </summary>
    public static class DistanceCalculator
    {
        private const double EarthRadiusInKm = 6371;

        /// <summary>
        /// Calculate the approximate distance driven for a single TruckPlan
        /// </summary>
        /// <param name="truckPlan"></param>
        /// <returns>distanceInKM</returns>
        public static double CalculateDistanceInKilometersForASingleTruckPlan(TruckPlan truckPlan)
        {
            return CalculateDistanceInKilometers(truckPlan.GpsCoordinates);
        }

        /// <summary>
        /// Calculate the approximate distance driven
        /// </summary>
        /// <param name="gpsCoordinates"></param>
        /// <returns>distanceInKM</returns>
        public static double CalculateDistanceInKilometers(List<GpsCoordinate> gpsCoordinates)
        {
            double distance = 0;

            for (int i = 1; i < gpsCoordinates.Count; i++)
            {
                distance += CalculateDistanceBetweenPoints(gpsCoordinates[i - 1], gpsCoordinates[i]);
            }

            return distance;
        }

        public static double CalculateDistanceBetweenPoints(GpsCoordinate gpsCoordinate1, GpsCoordinate gpsCoordinate2)
        {
            double dLat = ToRadians(gpsCoordinate2.Latitude - gpsCoordinate1.Latitude);
            double dLon = ToRadians(gpsCoordinate2.Longitude - gpsCoordinate1.Longitude);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(gpsCoordinate1.Latitude)) * Math.Cos(ToRadians(gpsCoordinate2.Latitude)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return EarthRadiusInKm * c;
        }

        private static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
    }
}
