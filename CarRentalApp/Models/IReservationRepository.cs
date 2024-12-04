
namespace CarRentalApp.Models
{
    public interface IReservationRepository
    {
        Task CreateReservationAsync(Reservation reservation);
    }
}