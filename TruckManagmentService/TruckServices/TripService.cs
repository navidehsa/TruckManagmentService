using TruckManagmentService.Helpers;
using TruckManagmentService.Services;
using TruckMangmentService.Models;

namespace TruckManagmentService.TruckServices
{
    public class TripService : ITripsService
    {
        private readonly IGeoService _geoService;

        public TripService(IGeoService geoService)
        {
            _geoService = geoService;
        }

        public async Task<double> GetTotalDistanceDrivenByDriversOver50InGermanyInFebruary2018Async(List<TruckPlan> trips)
        {
            DateTime startDate = new DateTime(2018, 2, 1);
            DateTime endDate = new DateTime(2018, 3, 1);
            double distancesDrivenByDriversOver50InFeburary2018 = 0;

            var tripsForDriversOver50inFeburary2018 = trips
                .Where(x => (DriverAgeCalculator.GetDriverAge(x.Driver) > 50) && (x.StartDate >= startDate && x.EndDate <= endDate));
          

            foreach(var trip in tripsForDriversOver50inFeburary2018)
            {
                if(await IsTripInGermanyAsync(trip.GpsCoordinates))
                {
                    distancesDrivenByDriversOver50InFeburary2018 += TripDistanceCalculater.CalculateDistanceDriven(trip);
                }
            }

            return distancesDrivenByDriversOver50InFeburary2018;
        }

        private async Task<bool> IsTripInGermanyAsync(List<GpsCoordinate> gpsCoordinates)
        {
            foreach (var gpsCoordinate in gpsCoordinates)
            {
                var country = await _geoService.GetCountryNameAsync(gpsCoordinate);
                if (country == "Germany")
                    return true;
            }
            return false;
        }
    }
}
