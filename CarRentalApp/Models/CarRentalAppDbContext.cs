using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Models
{
    public class CarRentalAppDbContext(DbContextOptions<CarRentalAppDbContext> options) : IdentityDbContext<AppUser, IdentityRole, string>(options)
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Booking)
                .WithOne(b => b.Reservation)
                .HasForeignKey<Reservation>(r => r.BookingId);

            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, Manufacturer = "Toyota", Model = "Corolla", Location = "New York", Year = 2020, LicensePlate = "ABC123", PricePerDay = 50, Status = "Available" },
                new Car { CarId = 2, Manufacturer = "Ford", Model = "Focus", Location = "Los Angeles", Year = 2021, LicensePlate = "XYZ789", PricePerDay = 60, Status = "Available" },
                new Car { CarId = 3, Manufacturer = "Honda", Model = "Civic", Location = "Chicago", Year = 2019, LicensePlate = "DEF456", PricePerDay = 55, Status = "Available" },
                new Car { CarId = 4, Manufacturer = "Tesla", Model = "Model 3", Location = "San Francisco", Year = 2022, LicensePlate = "TESLA1", PricePerDay = 120, Status = "Available" },
                new Car { CarId = 5, Manufacturer = "Chevrolet", Model = "Malibu", Location = "Houston", Year = 2020, LicensePlate = "CHEVRO", PricePerDay = 65, Status = "Available" }
            );

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = "5", FirstName = "John", LastName = "Doe", UserName = "john.doe", Email = "john.doe@example.com", AddressLine1 = "123 Main St", City = "New York", Country = "USA", DriversLicenseNumber = "D123456" },
                new AppUser { Id = "6", FirstName = "Jane", LastName = "Smith", UserName = "jane.smith", Email = "jane.smith@example.com", AddressLine1 = "456 Maple Ave", City = "Los Angeles", Country = "USA", DriversLicenseNumber = "D654321" }
                );

            modelBuilder.Entity<Booking>().HasData(
                new Booking { BookingId = 1, ReservationId = 1, StartDate = new DateOnly(2023, 11, 1), EndDate = new DateOnly(2023, 11, 5), Status = "Confirmed", ConfirmedAt = new DateOnly(2023, 10, 31) },
                new Booking { BookingId = 2, ReservationId = 2, StartDate = new DateOnly(2023, 12, 1), EndDate = new DateOnly(2023, 12, 10), Status = "Pending", ConfirmedAt = new DateOnly(2023, 11, 30) },
                new Booking { BookingId = 3, ReservationId = 3, StartDate = new DateOnly(2024, 1, 1), EndDate = new DateOnly(2024, 1, 5), Status = "Cancelled", ConfirmedAt = new DateOnly(2023, 12, 31) },
                new Booking { BookingId = 4, ReservationId = 4, StartDate = new DateOnly(2024, 2, 1), EndDate = new DateOnly(2024, 2, 7), Status = "Confirmed", ConfirmedAt = new DateOnly(2024, 1, 30) },
                new Booking { BookingId = 5, ReservationId = 5, StartDate = new DateOnly(2024, 3, 1), EndDate = new DateOnly(2024, 3, 5), Status = "Pending", ConfirmedAt = new DateOnly(2024, 2, 28) }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 1, CarId = 1, UserId = "5", BookingId = 1, StartDate = new DateOnly(2023, 11, 1), EndDate = new DateOnly(2023, 11, 5), ReservationStatus = "Confirmed", Cost = 250, CreatedAt = new DateOnly(2023, 10, 30), UpdatedAt = new DateOnly(2023, 10, 30) },
                new Reservation { ReservationId = 2, CarId = 2, UserId = "6", BookingId = 2, StartDate = new DateOnly(2023, 12, 1), EndDate = new DateOnly(2023, 12, 10), ReservationStatus = "Pending", Cost = 600, CreatedAt = new DateOnly(2023, 11, 29), UpdatedAt = new DateOnly(2023, 11, 29) },
                new Reservation { ReservationId = 3, CarId = 3, UserId = "5", BookingId = 3, StartDate = new DateOnly(2024, 1, 1), EndDate = new DateOnly(2024, 1, 5), ReservationStatus = "Cancelled", Cost = 275, CreatedAt = new DateOnly(2023, 12, 31), UpdatedAt = new DateOnly(2023, 12, 31) },
                new Reservation { ReservationId = 4, CarId = 4, UserId = "6", BookingId = 4, StartDate = new DateOnly(2024, 2, 1), EndDate = new DateOnly(2024, 2, 7), ReservationStatus = "Confirmed", Cost = 840, CreatedAt = new DateOnly(2024, 1, 29), UpdatedAt = new DateOnly(2024, 1, 29) },
                new Reservation { ReservationId = 5, CarId = 5, UserId = "5", BookingId = 5, StartDate = new DateOnly(2024, 3, 1), EndDate = new DateOnly(2024, 3, 5), ReservationStatus = "Pending", Cost = 325, CreatedAt = new DateOnly(2024, 2, 28), UpdatedAt = new DateOnly(2024, 2, 28) }
            );
        }
    }
}
