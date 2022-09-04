using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;

namespace EindWerk_CinemaTicket.Data.Repositories
{
    public class MovieRepo : GenericRepo<Movie>, IMovie
    {
        public MovieRepo(AppDbContext context) : base(context)
        {
        }
    }
}
