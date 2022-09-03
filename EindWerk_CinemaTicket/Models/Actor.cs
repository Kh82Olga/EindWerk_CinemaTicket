using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class Actor
    {
        
        //[Key]
        public int ActorId { get; set; }
        [Display(Name = "Profile picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Actor's name is required")]
        public string FullName { get; set;}
        public virtual List<ActorMovie> ActorMovies { get; set; }

    }
}
