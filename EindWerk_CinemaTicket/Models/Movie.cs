using EindWerk_CinemaTicket.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EindWerk_CinemaTicket.Models
{
    public class Movie: IBase
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        //public DateTime Start { get; set; }
        //public DateTime End { get; set; }
        public virtual List<ActorMovie> ActorMovies { get; set; }
        public int CinemaHallId { get; set; }
        [ForeignKey("CinemaHallId")]
        public virtual CinemaHall CinemaHall { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }

    }
}
