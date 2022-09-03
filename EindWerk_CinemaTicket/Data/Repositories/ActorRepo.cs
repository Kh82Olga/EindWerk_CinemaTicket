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
        public async Task DeleteAsync(int Id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == Id);
            _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Actor>> GetAllAsync()
        {
            var result= await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int Id)
        {
            var result= await _context.Actors.FirstOrDefaultAsync(x => x.ActorId == Id);
            return result;
        }

        public async Task InsertAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> UpdateAsync(Actor actor)
        {
            _context.Actors.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }
}
