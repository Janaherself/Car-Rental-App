namespace CarRentalApp.Models
{
    public class ReservationRepository(CarRentalAppDbContext context) : IReservationRepository
    {
        public async Task CreateReservationAsync(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            await context.SaveChangesAsync();
        }
    }
}
