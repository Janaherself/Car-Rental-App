namespace CarRentalApp.Models
{
    public record Booking
    {
        public int BookingId { get; set; }
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
        public required DateOnly StartDate { get; set; }
        public required DateOnly EndDate { get; set; }
        public required string Status { get; set; }
        public required DateOnly ConfirmedAt { get; set; }
    }
}
