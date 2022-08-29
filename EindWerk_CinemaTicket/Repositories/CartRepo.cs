using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Interfaces;
using EindWerk_CinemaTicket.Models;
using System.Collections.Generic;

namespace EindWerk_CinemaTicket.Repositories
{
    public class CartRepo : ICart
    {
        private readonly ApplicationDbContext _context;
        public CartRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteItem(Cart cart)
        {
            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }

        public IEnumerable<Cart> GetCartDetails() => _context.Carts;

        public void UpdateQuantity(Cart cart)
        {
            _context.Carts.Update(cart);
            _context.SaveChanges();
        }
    }
}
