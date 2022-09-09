using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data.Interfaces
{
    public interface IOrder
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmail);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
