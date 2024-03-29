﻿using EindWerk_CinemaTicket.Models;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data.Interfaces
{
    public interface IMovie : IGeneric<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<Dropdowns> GetDropdownsValues();
        Task CreateNewMovieAsync(CreateMovie data);
        Task UpdateMovieAsync(CreateMovie data);

    }
}
