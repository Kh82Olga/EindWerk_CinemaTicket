using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EindWerk_CinemaTicket.Models
{
    public class Timetable
    {
        [Key]
        public int SessionId { get; set; }
        public DateTime Day { get; set; }
        public string Time { get; set; }
        public int AvailableSeats { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }

    }
}
