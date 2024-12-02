namespace CarRentalApp.Models
{
    public record Car
    {
        public int CarId { get; set; }
        public required string Manufacturer { get; set; }
        public required string Model { get; set; }
        public required string Location { get; set; }
        public required int Year { get; set; }
        public required string LicensePlate { get; set; }
        public required decimal PricePerDay { get; set; }
        public required string Status { get; set; }
        public List<Reservation> Reservations { get; set; } = [];
    }
}
