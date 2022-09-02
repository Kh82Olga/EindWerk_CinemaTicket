using EindWerk_CinemaTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Controllers
{
    public class CinemaHallController : Controller
    {
        private readonly AppDbContext _context;
        public CinemaHallController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.CinemaHalls.ToListAsync();
            return View(allCinemas);
        }
    }
}
