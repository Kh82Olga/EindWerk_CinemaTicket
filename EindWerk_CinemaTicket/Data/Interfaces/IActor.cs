using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data.Interfaces
{
    public interface IActor
    {
        Task<List<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int Id);
        Task InsertAsync(Actor actor);
        Task<Actor> UpdateAsync(Actor actor);
        Task DeleteAsync(int Id);
    }
}
