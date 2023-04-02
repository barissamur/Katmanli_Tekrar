using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Interfaces;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IYazarlarViewModelService _yazarlarRepo;

        public HomeController(ILogger<HomeController> logger,
            IYazarlarViewModelService yazarlarRepo)
        {
            _logger = logger;
            _yazarlarRepo = yazarlarRepo;
        }

        public async Task<IActionResult> Index()
        {
            var yazarlarVm = await _yazarlarRepo.GetYazarlarVm();
            return View(yazarlarVm);
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
    }
}