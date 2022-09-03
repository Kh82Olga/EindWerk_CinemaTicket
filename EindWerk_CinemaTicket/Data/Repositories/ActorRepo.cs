using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }

        public async Task<List<Actor>> GetAll()
        {
            var result= await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int Id)
        {
            return _context.Actors.FirstOrDefault(x => x.ActorId == Id);
        }

        public void Insert(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Update(Actor actor)
        {
            _context.Actors.Update(actor);
            _context.SaveChanges();
        }
    }
}
