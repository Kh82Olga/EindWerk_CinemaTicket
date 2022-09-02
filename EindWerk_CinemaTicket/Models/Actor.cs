using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class Actor
    {
        
        //[Key]
        public int ActorId { get; set; }
        [Display(Name = "Profile picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set;}
        public virtual List<ActorMovie> ActorMovies { get; set; }

    }
}
