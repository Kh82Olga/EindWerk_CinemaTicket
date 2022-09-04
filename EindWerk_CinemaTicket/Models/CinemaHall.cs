using EindWerk_CinemaTicket.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class CinemaHall: IBase
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
