using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;

namespace VideoRental.Interfaces
{
    public interface IMovie
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int Id);
        void Insert(Movie movie);
        void Update(Movie movie);
        void Delete(Movie movie);
    }
}
