using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;
using System.Linq;

namespace EindWerk_CinemaTicket.Data.Repositories
{
    public class ActorRepo : IActor
    {
        private readonly AppDbContext _context;
        public ActorRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Actor> GetAll()
        {
            var result = _context.Actors.ToList();
            return result;
        }

        public Actor GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Actor actor)
        {
            throw new System.NotImplementedException();
        }
    }
}
