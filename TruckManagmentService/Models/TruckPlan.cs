namespace TruckMangmentService.Models
{
    /// <summary>
    ///  TruckPlan that describe a single driver, driving a truck for a continuous period, such as a five-hour drive through Germany on a specific date
    /// </summary>
    public class TruckPlan
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Truck Truck { get; set; }

        public Driver Driver { get; set; }

        public List<GpsCoordinate> GpsCoordinates { get; set; }
    }
}
