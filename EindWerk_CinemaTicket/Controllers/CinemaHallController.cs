using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Migrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CinemaHallController : Controller
    {
        private readonly ICinemaHall _service;

        public CinemaHallController(ICinemaHall service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemaDetails);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> InsertAsync(CinemaHall cinemaHall)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(cinemaHall);
        //    }
        //    await _service.InsertAsync(cinemaHall);
        //    return RedirectToAction(nameof(Index));
        //}
        public async Task<IActionResult> Update(int id)
        {
            var cinemaHall = await _service.GetByIdAsync(id);
            if (cinemaHall == null)
            {
                return View("NotFound");
            }
            return View(cinemaHall);
        }
        //[HttpPost]
        //public async Task<IActionResult> Update(CinemaHall cinemaHall)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(cinemaHall);
        //    }
        //    await _service.UpdateAsync(cinemaHall);
        //    return RedirectToAction(nameof(Index));
        //}
        //[HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaHall = await _service.GetByIdAsync(id);
            if (cinemaHall == null)
            {
                return View("NotFound");
            }
            return View(cinemaHall);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaHall = await _service.GetByIdAsync(id);
            if (cinemaHall == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
