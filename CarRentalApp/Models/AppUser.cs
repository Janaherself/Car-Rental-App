using Microsoft.AspNetCore.Identity;

namespace CarRentalApp.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string DriversLicenseNumber { get; set; }
    }

}
