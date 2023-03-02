namespace TruckMangmentService.Models
{
    /// <summary>
    /// A vehicle used for transportation, equipped with a GPS device that provides its current position approximately every 5 minutes. 
    /// </summary>
    public class Truck
    {
        public string RegistrationNumber { get; set; }

        // Other relevant details such as GpsDevice code, Model....
    }
}
