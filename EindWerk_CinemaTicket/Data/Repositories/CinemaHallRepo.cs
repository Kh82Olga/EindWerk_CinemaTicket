using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;

namespace EindWerk_CinemaTicket.Data.Repositories
{
    public class CinemaHallRepo: GenericRepo<CinemaHall>, ICinemaHall
    {
        public CinemaHallRepo(AppDbContext context) : base(context)
        {
        }
    }
}
