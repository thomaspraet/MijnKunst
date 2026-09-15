using Microsoft.AspNetCore.Mvc;
using MijnKunst.web.Data;
using MijnKunst.Models;
using MijnKunst.Business.Services.IServices;

namespace MijnKunst.web.Areas.Admin.Controllers
{
    [Area("Admin")] 
    public class TechnicController : Controller
    {
        private readonly ITechnicService _technicService;
        public TechnicController(ITechnicService technicService)
        {
            _technicService = technicService;
        }
        public async Task<IActionResult> Index()
        {
            var technics = await _technicService.GetAllTechnicsAsync();
            return View(technics);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreatePOST(Technic technic)
        {
            if (ModelState.IsValid)
            {
                await _technicService.CreateTechnicAsync(technic);
                return RedirectToAction("Index");
            }

            return View();
        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var technic = await _technicService.GetTechnicByIdAsync(id.Value);
            if (technic == null)
            {
                return NotFound();
            }
            return View(technic);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Update")]
        public async Task<IActionResult> UpdatePOST(Technic technic)
        {
            if (ModelState.IsValid)
            {
                await _technicService.UpdateTechnicAsync(technic);
                return RedirectToAction("Index");
            }
            return View(technic);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var technic = await _technicService.GetTechnicByIdAsync(id.Value);
            if (technic == null)
            {
                return NotFound();
            }
            return View(technic);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _technicService.DeleteTechnicAsync(id);
            return RedirectToAction("Index");
        }
    }
}