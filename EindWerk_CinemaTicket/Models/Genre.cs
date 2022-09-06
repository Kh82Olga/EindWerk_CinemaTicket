using EindWerk_CinemaTicket.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EindWerk_CinemaTicket.Models
{
    public class Genre:IBase
    {
        [Key]
        //[Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Genre")]
        [Required (ErrorMessage ="Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage ="Name must be between 3 and 30 chars")]
        public string GenreName { get; set; }
        public string Description { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
