using EindWerk_CinemaTicket.Data;
using System.Collections.Generic;
using System.Linq;
using EindWerk_CinemaTicket.Models;
using EindWerk_CinemaTicket.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EindWerk_CinemaTicket.Repositories
{
    public class GenreRepo:IGenre
    {
        private readonly ApplicationDbContext _context;
        public GenreRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(Genre genre)
        {
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }

        public IEnumerable<Genre> GetAll() => _context.Genres;
        public Genre GetById(int Id)
        {
            return _context.Genres.FirstOrDefault(x => x.GenreId == Id);
        }

        public void Insert(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public void Update(Genre genre)
        {
            _context.Genres.Update(genre);
            _context.SaveChanges();
        }
    }
}
