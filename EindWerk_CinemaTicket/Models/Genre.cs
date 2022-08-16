using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
