using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.Repositories;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Controllers
{
    public class ActorController : Controller
    {
        private readonly ActorRepo _actorRepo;

        public ActorController(ActorRepo actorRepo)
        {
            _actorRepo = actorRepo;
        }
        public async Task<IActionResult> Index()
        {
            var actors = await _actorRepo.GetAllAsync();
            return View(actors);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertAsync(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorRepo.InsertAsync(actor);
            return RedirectToAction(nameof(Index));
            
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorRepo.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }
            return View(actorDetails);
        }
        
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var actor = await _actorRepo.GetByIdAsync(id);
            if (actor == null)
            {
                return View("Not Found");
            }
            return View(actor);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorRepo.UpdateAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var actor = _actorRepo.GetByIdAsync(id);
            return View(actor);
        }
        [HttpPost]
        public IActionResult Delete(Actor actor)
        {
            _actorRepo.Delete(actor);
            return View();
        }
    }
}
