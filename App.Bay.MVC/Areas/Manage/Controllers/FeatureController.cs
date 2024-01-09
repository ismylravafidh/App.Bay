using App.Bay.Business.Services.Interfaces;
using App.Bay.Business.ViewModels.FeatureVm;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Bay.MVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _service;

        public FeatureController(IFeatureService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            List<FeatureGetVm> features =await _service.GetAllAsync();
            return View(features);
        }
        public async Task<IActionResult> Create()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(FeatureCreateVm createVm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _service.Create(createVm);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var feature = await _service.GetByIdAsync(id);
            return View(feature);
        }
        [HttpPost]
        public async Task<IActionResult> Update(FeatureUpdateVm updateVm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _service.Update(updateVm);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _service.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
