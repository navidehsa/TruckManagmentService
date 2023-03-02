
namespace TruckMangmentService.Models
{
    /// <summary>
    /// The Driver class represents a driver who can drive a truck. 
    /// </summary>
    public class Driver
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        // Other relevant details such as address, phone number, etc.
    }
}
