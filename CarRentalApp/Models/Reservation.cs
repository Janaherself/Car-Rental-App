namespace CarRentalApp.Models
{
    public record Reservation
    {
        public int ReservationId { get; set; }
        public int CarId { get; set; }
        public Car? Car { get; set; }
        public string UserId { get; set; } = string.Empty;
        public AppUser? User { get; set; }
        public int BookingId { get; set; }
        public Booking? Booking { get; set; }
        public required DateOnly StartDate {  get; set; }
        public required DateOnly EndDate { get; set; }
        public required string ReservationStatus { get; set; }
        public required decimal Cost { get; set; }
        public required DateOnly CreatedAt { get; set; }
        public required DateOnly UpdatedAt { get; set; }
    }
}
