using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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

        public Task CreateNewMovie(CreateMovie data)
        {
           
        }

        public async Task<Dropdowns> GetDropdownsValues()
        {
            var response=new Dropdowns();
            response.Actors=await _context.Actors.OrderBy(n=>n.FullName).ToListAsync();
            response.CinemaHalls=await _context.CinemaHalls.OrderBy(n=>n.Name).ToListAsync();
            response.Genres=await _context.Genres.OrderBy(n=>n.GenreName).ToListAsync();
            return response;

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
