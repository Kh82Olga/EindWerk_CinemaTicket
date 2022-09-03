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
            var data = await _actorRepo.GetAll();
            return View(data);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Actor actor)
        {
            _actorRepo.Insert(actor);
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var actor = _actorRepo.GetById(id);
            return View(actor);
        }
        [HttpPost]
        public IActionResult Update(Actor actor)
        {
            _actorRepo.Update(actor);
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var actor = _actorRepo.GetById(id);
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
