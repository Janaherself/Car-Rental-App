using CarRentalApp.Models;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.App.Pages
{
    public partial class Search
    {
        public string SearchLocation = "";
        public string SearchName = "";

        public List<Car> FoundCars { get; set; } = [];

		public class CarSearchModel
		{
            [Required]
			public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
            [Required]
			public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Today.AddDays(1));
        }

		private readonly CarSearchModel searchModel = new();

		[Inject]
        public ICarRepository? CarRepository { get; set; }

        private async Task SearchByLocation()
        {
            FoundCars.Clear();
            if (CarRepository != null)
            {
                FoundCars = await CarRepository.SerachCarsByLocation(SearchLocation) ?? [];
            }
        }


        private async Task SearchByName()
        {
            FoundCars.Clear();
			if (CarRepository != null)
			{
				FoundCars = await CarRepository.SerachCarsByName(SearchName) ?? [];
			}
		}


        private async Task SearchByDate()
        {
            FoundCars.Clear();
			if (CarRepository != null)
			{
				FoundCars = await CarRepository.SerachCarsByDate(searchModel.StartDate, searchModel.EndDate) ?? [];
			}
		}
    }
}
