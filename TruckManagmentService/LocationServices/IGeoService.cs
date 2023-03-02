using TruckMangmentService.Models;

namespace TruckManagmentService.Services
{
    public interface IGeoService
    {
        public Task<string> GetCountryNameAsync(GpsCoordinate gpsCoordinate);
    }
}
