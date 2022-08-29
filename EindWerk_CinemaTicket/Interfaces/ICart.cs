using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Interfaces
{
    public interface ICart
    {
        IEnumerable<Cart> GetCartDetails();
       
        void UpdateQuantity(Cart cart);
        void DeleteItem(Cart cart);
    }
}
