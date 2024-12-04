using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.ViewModels
{
    public class ManageProfileViewModel
    {
        [Display(Name = "Userame")]
        public string? Username { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        
        [Display(Name = "Phone Number")]
        [Phone]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Address Line 1")]
        public string? AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "Country")]
        public string? Country { get; set; }

        [Display(Name = "Driver's License Number")]
        public string? DriversLicenseNumber { get; set; }
    }
}
