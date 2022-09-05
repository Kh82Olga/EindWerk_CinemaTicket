using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data.Repositories
{
    public class MovieRepo : GenericRepo<Movie>, IMovie
    {
        private readonly AppDbContext _context;
        public MovieRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails=await _context.Movies
                .Include(c=>c.CinemaHall)
                .Include(g=>g.Genre)
                .Include(am=>am.ActorMovies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n=>n.Id==id);
            return movieDetails;
        }
    }
}
