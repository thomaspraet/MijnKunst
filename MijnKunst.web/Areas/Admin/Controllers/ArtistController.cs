using Microsoft.AspNetCore.Mvc;
using MijnKunst.web.Data;
using MijnKunst.Models;
using MijnKunst.Business.Services.IServices;

namespace MijnKunst.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }
        public async Task<IActionResult> Index()
        {
            var artists = await _artistService.GetAllArtistsAsync();
            return View(artists);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreatePOST(Artist artist)
        {
            if (ModelState.IsValid)
            {
                await _artistService.CreateArtistAsync(artist);
                return RedirectToAction("Index");
            }
            return View(artist);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var artist = await _artistService.GetArtistByIdAsync(id.Value);
            if (artist == null)
            {
                return NotFound();
            }
            return View(artist);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Update")]
        public async Task<IActionResult> UpdatePOST(Artist artist)
        {
            if (ModelState.IsValid)
            {
                await _artistService.UpdateArtistAsync(artist);
                return RedirectToAction("Index");
            }
            return View(artist);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var artist = await _artistService.GetArtistByIdAsync(id.Value);
            if (artist == null)
            {
                return NotFound();
            }
            return View(artist);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePOST(int id)
        { 
            await _artistService.DeleteArtistAsync(id);
            return RedirectToAction("Index");
        }
    }
}
