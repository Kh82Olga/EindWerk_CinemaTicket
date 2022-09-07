using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            return View(movieDetails);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var dropdownsData = await _service.GetDropdownsValues();
            ViewBag.CinemaHalls = new SelectList(dropdownsData.CinemaHalls, "Id", "Name");
            ViewBag.Genres = new SelectList(dropdownsData.Genres, "Id", "GenreName");
            ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMovie movie)
        {
            if (!ModelState.IsValid)
            {
                var dropdownsData = await _service.GetDropdownsValues();
                ViewBag.CinemaHalls = new SelectList(dropdownsData.CinemaHalls, "Id", "Name");
                ViewBag.Genres = new SelectList(dropdownsData.Genres, "Id", "GenreName");
                ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");
                return View();
            }
            await _service.CreateNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var movieDetails=await _service.GetMovieByIdAsync(id);
            if (movieDetails==null)
            {
                return View("NotFound");
            }
            var response = new CreateMovie()
            {
                Id = movieDetails.Id,
                MovieName = movieDetails.MovieName,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                Image = movieDetails.Image,
                ActorIds = movieDetails.ActorMovies.Select(n => n.ActorId).ToList(),
                GenreId = movieDetails.GenreId,
                CinemaHallId = movieDetails.CinemaHallId,
            };
            var dropdownsData = await _service.GetDropdownsValues();
            ViewBag.CinemaHalls = new SelectList(dropdownsData.CinemaHalls, "Id", "Name");
            ViewBag.Genres = new SelectList(dropdownsData.Genres, "Id", "GenreName");
            ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, CreateMovie movie)
        {
            if (movie.Id == null)
            {
                return View("NotFound");
            }
            if (!ModelState.IsValid)
            {
                var dropdownsData = await _service.GetDropdownsValues();
                ViewBag.CinemaHalls = new SelectList(dropdownsData.CinemaHalls, "Id", "Name");
                ViewBag.Genres = new SelectList(dropdownsData.Genres, "Id", "GenreName");
                ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");
                return View();
            }
            await _service.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}
