using EmreBilet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmreBilet.Controllers
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
        [Route("/hakkimizda")]
        public IActionResult Hakkimizda()
        {
            return View();
        }

        [Route("/iletisim")]
        public IActionResult Iletisim()
        {
            return View();
        }

        [Route("/ucuslar")]
        public IActionResult Ucuslar()
        {
            return View();
        }

        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/kayitol")]
        public IActionResult Kayitol()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
