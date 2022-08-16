using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EindWerk_CinemaTicket.Models
{
    public class TicketOrder
    {
        [Key]
        public int TicketId { get; set; }
        public int SessionId { get; set; }
        [ForeignKey("SessionId")]
        public virtual Timetable Timetable { get; set; }
        public int SeatId { get; set; }
        [ForeignKey("SeatId")]
        public virtual CinemaSeat CinemaSeat { get; set; }

    }
}
