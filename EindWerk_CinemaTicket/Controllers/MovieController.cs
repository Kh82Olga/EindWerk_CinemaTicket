using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovie _service;

        public MovieController(IMovie service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n=>n.CinemaHall);
            return View(allMovies);
        }
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            return View(movieDetails);
        }
    }
}
