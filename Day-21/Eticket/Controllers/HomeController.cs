using Eticket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eticket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

      

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ContactUs()
        {
            return View();
        }
      
    }
}
