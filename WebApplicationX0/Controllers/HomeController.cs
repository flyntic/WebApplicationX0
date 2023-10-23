using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationX0.Models;
using WebApplicationX0.Services;

namespace WebApplicationX0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeViewModel homeViewModel = new HomeViewModel(); 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
         
            return View(homeViewModel);
          
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Found(int? numberDecimal)
        {
            homeViewModel.number=numberDecimal;
            homeViewModel.romeNumber = numberDecimal.RomeNumber();
            return View(homeViewModel);
            
        }

    }
}