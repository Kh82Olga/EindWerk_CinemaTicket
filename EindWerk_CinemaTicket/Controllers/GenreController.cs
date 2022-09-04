using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenre _service;

        public GenreController(IGenre service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allGenres = await _service.GetAllAsync();
            return View(allGenres);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var genreDetails = await _service.GetByIdAsync(id);
            if (genreDetails == null)
            {
                return View("NotFound");
            }
            return View(genreDetails);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertAsync(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View(genre);
            }
            await _service.InsertAsync(genre);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var genre = await _service.GetByIdAsync(id);
            if (genre == null)
            {
                return View("NotFound");
            }
            return View(genre);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View(genre);
            }
            await _service.UpdateAsync(genre);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var genre = await _service.GetByIdAsync(id);
            if (genre == null)
            {
                return View("NotFound");
            }
            return View(genre);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genre = await _service.GetByIdAsync(id);
            if (genre == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
