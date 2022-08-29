using EindWerk_CinemaTicket.Models;
using EindWerk_CinemaTicket.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EindWerk_CinemaTicket.Controllers
{
    public class GenreController : Controller
    {
        
            private readonly GenreRepo _genreRepo;

            public GenreController(GenreRepo genreRepo)
            {
                _genreRepo = genreRepo;
            }
            public IActionResult Index()
            {
                var genres = _genreRepo.GetAll();
                return View(genres);
            }
            [HttpGet]
            public IActionResult Insert()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Insert(Genre genre)
            {
                _genreRepo.Insert(genre);
                return View();
            }
            [HttpGet]
            public IActionResult Update(int id)
            {
                var genre = _genreRepo.GetById(id);
                return View(genre);
            }
            [HttpPost]
            public IActionResult Update(Genre genre)
            {
                _genreRepo.Update(genre);
                return View();
            }
            [HttpGet]
            public IActionResult Delete(int id)
            {
                var genre = _genreRepo.GetById(id);
                return View(genre);
            }
            [HttpPost]
            public IActionResult Delete(Genre genre)
            {
                _genreRepo.Delete(genre);
                return View();
            }
        
}   }
