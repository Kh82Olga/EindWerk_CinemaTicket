using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data.Interfaces
{
    public interface IActor
    {
        Task<List<Actor>> GetAll();
        Actor GetById(int Id);
        void Insert(Actor actor);
        void Update(Actor actor);
        void Delete(Actor actor);
    }
}
