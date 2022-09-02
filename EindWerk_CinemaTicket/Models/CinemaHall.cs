using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class CinemaHall
    {
        //[Key]
        public int CinemaHallId { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
