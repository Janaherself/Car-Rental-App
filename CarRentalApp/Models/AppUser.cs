using Microsoft.AspNetCore.Identity;

namespace CarRentalApp.Models
{
    public class AppUser : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public required string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string DriversLicenseNumber { get; set; }
        public List<Reservation> Reservations { get; set; } = [];
    }

}
