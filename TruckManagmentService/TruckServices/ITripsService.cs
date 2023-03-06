using TruckMangmentService.Models;

namespace TruckManagmentService.TruckServices
{
    public interface ITripsService
    {
        //TODO  we should parametrize this method to be genric 
        // Task<double> GetTotalDistance(string countryName,int year, int month, int driverAge);
        Task<double> GetTotalDistanceDrivenByDriversOver50InGermanyInFebruary2018Async(List<TruckPlan> trips);
    }
}
