using CarRentalApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentalApp.Views.Home
{
    public class CarReservationModel(ICarRepository _carRepository, IReservationRepository _reservationRepository) : PageModel
    {
        [BindProperty]
        public Car? Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int carId)
        {
            Car = await _carRepository.GetByIdAsync(carId);
            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int carId, DateOnly startDate, DateOnly endDate)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            var numberOfDays = (endDate.ToDateTime(TimeOnly.MinValue) - startDate.ToDateTime(TimeOnly.MinValue)).Days;

            var reservation = new Reservation
            {
                CarId = carId,
                StartDate = startDate,
                EndDate = endDate,
                Cost = numberOfDays * Car!.PricePerDay,
                CreatedAt = today,
                UpdatedAt = today,
                ReservationStatus = "Pending",
                UserId = User.Identity!.Name!
            };

            await _reservationRepository.CreateReservationAsync(reservation);

            return RedirectToPage("/");
        }
    }
}