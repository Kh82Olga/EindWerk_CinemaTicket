using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public List<TicketOrder> TicketOrders { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
    }
}
