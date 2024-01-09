using App.Bay.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Bay.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureService _service;

        public HomeController(IFeatureService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var features = await _service.GetAllAsync();
            return View(features);
        }
    }
}
