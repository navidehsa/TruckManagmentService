using TruckMangmentService.Models;

namespace TruckManagmentService.TruckServices
{
    public interface ITripsService
    {
        Task<double> GetTotalDistanceDrivenByDriversOver50InGermanyInFebruary2018Async(List<TruckPlan> trips);
    }
}
