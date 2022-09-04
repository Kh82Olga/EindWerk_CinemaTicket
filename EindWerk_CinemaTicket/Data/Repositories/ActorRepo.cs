using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data.Repositories
{
    public class ActorRepo : GenericRepo<Actor>, IActor
    {
        public ActorRepo(AppDbContext context): base(context)
        {
        }
       
    }
}
