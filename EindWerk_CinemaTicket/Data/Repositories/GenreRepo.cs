using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;

namespace EindWerk_CinemaTicket.Data.Repositories
{
    public class GenreRepo: GenericRepo<Genre>, IGenre
    {
        public GenreRepo(AppDbContext context):base(context)
        {

        }
    }
}
