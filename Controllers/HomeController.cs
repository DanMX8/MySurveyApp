using Microsoft.AspNetCore.Mvc;
using MySurveyApp.Models;
using System.Diagnostics;

namespace MySurveyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Blazor()
        {
            return View("_Host");
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("fetchdata")]
        public IActionResult FetchData()
        {
            return View();
        }
        [Route("counter")]
        public IActionResult Counter()
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