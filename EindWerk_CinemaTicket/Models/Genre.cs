using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EindWerk_CinemaTicket.Models
{
    public class Genre
    {
        [Key]
        [Column("Id")]
        public int GenreKey { get; set; }
        [Display(Name = "Genre")]
        public string GenreName { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
