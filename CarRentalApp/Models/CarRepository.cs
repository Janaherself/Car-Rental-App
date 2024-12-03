using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Models
{
    public class CarRepository(CarRentalAppDbContext _context) : ICarRepository
    {
        public async Task<Car?> GetByIdAsync(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task<List<Car>?> SerachCarsByLocation(string searchQuery)
        {
            return await _context.Cars.Where(c => c.Location.Contains(searchQuery)).ToListAsync();
        }

        public async Task<List<Car>?> SerachCarsByName(string searchQuery)
        {
            return await _context.Cars.Where(c => c.Manufacturer.Contains(searchQuery) || c.Model.Contains(searchQuery)).ToListAsync();
        }

        public async Task<List<Car>?> SerachCarsByDate(DateOnly startDate, DateOnly endDate)
        {
            return await _context.Cars.Where(c => 
                !_context.Reservations.Any( 
                    r => r.CarId == c.CarId && 
                    ( !(endDate < r.StartDate || startDate > r.EndDate) )
                )).ToListAsync();
        }
    }
}
