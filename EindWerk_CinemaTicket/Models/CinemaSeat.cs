using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class CinemaSeat
    {
        [Key]
        public int SeatId { get; set; }
        public string SeatNumber { get; set;}
        public int PriceAdult = 15;
        public int PriceChild = 5;
    }
}
