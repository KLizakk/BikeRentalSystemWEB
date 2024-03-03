using BikeRentalSystemWEB.Models;
using BikeRentalSystemWEB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BikeRentalSystemWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEnumerable<BikeDetailViewModel> _bikes = new List<BikeDetailViewModel>
        {
            new BikeDetailViewModel{
                Id = 1,
                Producer = "Giant",
                Model = "RCR56-1",
                NumberOfGears = 21,
                Color = "Black",
                bikeType = BikeTypeModel.Male,
              },
            new BikeDetailViewModel
            {
                Id = 2,
                Producer = "Giant",
                Model = "RCR56-2",
                NumberOfGears = 24,
                Color = "Black",
                bikeType = BikeTypeModel.Female,
                NumberOfBikes = 2
            },
            new BikeDetailViewModel
            {
                Id = 3,
                Producer = "Giant",
                Model = "RCR56-3",
                NumberOfGears = 21,
                Color = "Black",
                bikeType = BikeTypeModel.Kids,
                NumberOfBikes = 3
            }
        };

    



public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View (_bikes);
        }

       

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
