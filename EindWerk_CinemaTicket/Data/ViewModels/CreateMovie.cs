using EindWerk_CinemaTicket.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EindWerk_CinemaTicket.Models
{
    public class CreateMovie
    {
       [Display(Name="Movie Name")]
       [Required(ErrorMessage ="Name is Required")]
        public string MovieName { get; set; }
        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Display(Name = "Price €")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }
        [Display(Name = "Movie Picture")]
        [Required(ErrorMessage = "Movie Picture is Required")]
        public string Image { get; set; }
        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Movie Actor(s) is Required")]
        public virtual List<int> ActorIds { get; set; }
        [Display(Name = "Select Cinema Hall")]
        [Required(ErrorMessage = "Cinema Hall is Required")]
        public int CinemaHallId { get; set; }
        [Display(Name = "Select Genre")]
        [Required(ErrorMessage = "Movie Genre is Required")]
        public int GenreId { get; set; }
        

    }
}
