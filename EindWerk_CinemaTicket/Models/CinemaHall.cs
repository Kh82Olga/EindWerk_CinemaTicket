using EindWerk_CinemaTicket.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class CinemaHall: IBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 15 chars")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
