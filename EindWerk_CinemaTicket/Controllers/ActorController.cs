using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EindWerk_CinemaTicket.Controllers
{
    public class ActorController : Controller
    {
        private readonly ActorRepo _actorRepo;

        public ActorController(ActorRepo actorRepo)
        {
            _actorRepo = actorRepo;
        }
        public IActionResult Index()
        {
            var data = _actorRepo.ToList();
            return View(data);
        }
    }
}
