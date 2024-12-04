using CarRentalApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentalApp.Views.Home
{
    public class CustomerIndexModel(ICarRepository carRepository) : PageModel
    {
        public List<Car> AvailableCars { get; set; } = [];

        public async Task OnGetAsync()
        {
            AvailableCars = await carRepository.GetAvailableCarsAsync();
        }
    }
}
