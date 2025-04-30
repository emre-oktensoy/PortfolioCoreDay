using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Models;

namespace PortofolioCoreDay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Home/Error/{code}")]
        public IActionResult Error(int code)
        {
            if (code == 404)
            {
                return View("~/Views/Shared/Error404.cshtml");
            }
            return View("Error"); // Diðer hata türleri için genel bir hata sayfasý
        }

    }
}
