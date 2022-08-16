using System.ComponentModel.DataAnnotations.Schema;

namespace EindWerk_CinemaTicket.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }


    }
}
