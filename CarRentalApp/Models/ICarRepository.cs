
namespace CarRentalApp.Models
{
    public interface ICarRepository
    {
        Task<Car?> GetByIdAsync(int id);
        Task<List<Car>?> SerachCarsByDate(DateOnly startDate, DateOnly endDate);
        Task<List<Car>?> SerachCarsByLocation(string searchQuery);
        Task<List<Car>?> SerachCarsByName(string searchQuery);
    }
}