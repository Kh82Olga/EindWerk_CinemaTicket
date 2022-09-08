using EindWerk_CinemaTicket.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class Actor:IBase
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Actor's name is required")]
        public string FullName { get; set;}
        public string Imdb { get; set; }
        public virtual List<ActorMovie> ActorMovies { get; set; }

    }
}
