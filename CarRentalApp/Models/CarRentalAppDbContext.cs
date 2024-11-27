using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Models
{
    public class CarRentalAppDbContext : IdentityDbContext
    {
        public CarRentalAppDbContext(DbContextOptions<CarRentalAppDbContext> options) : base(options)
        {
            
        }
    }
}
