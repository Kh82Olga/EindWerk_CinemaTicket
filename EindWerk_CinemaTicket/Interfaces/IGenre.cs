using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Interfaces
{
    public interface IGenre
    {
        IEnumerable<Genre> GetAll();
        Genre GetById(int Id);
        void Insert(Genre genre);
        void Update(Genre genre);
        void Delete(Genre genre);
    }
}
