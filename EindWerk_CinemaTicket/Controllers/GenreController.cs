using EindWerk_CinemaTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Controllers
{
    public class GenreController : Controller
    {
        private readonly AppDbContext _context;
        public GenreController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allGenres = await _context.Genres.ToListAsync();
            return View(allGenres);
        }
    }
}
