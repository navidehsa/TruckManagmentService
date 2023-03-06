
namespace TruckMangmentService.Models
{
    /// <summary>
    /// The GpsCoordinate class represents a geographic coordinate with properties such as Latitude and Longitude.
    /// </summary>
    public class GpsCoordinate
    {
        /// <summary>
        /// Latitude measures the distance north or south of the equator.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Longitudes are vertical lines that measure east or west of the meridian in Greenwich, England.
        /// </summary>
        public double Longitude { get; set; }
    }
}
