using EindWerk_CinemaTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EindWerk_CinemaTicket.Data.ShoppingCart
{
    public class ShoppingCart
    {
        public AppDbContext _context { get; set; }
        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public void AddToCart(Movie movie)
        {
            var shoppingCartItem=_context.ShoppingCartItems.FirstOrDefault(n=>n.Movie.Id== movie.Id && n.ShoppingCartId==ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    Movie = movie,
                    Amount = 1
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId)
                .Include(n => n.Movie).ToList());
        }
        public double GetTotal()
        {
            var total = _context.ShoppingCartItems.Where(n=>n.ShoppingCartId==ShoppingCartId)
                .Select(n=>n.Movie.Price * n.Amount).Sum();
            return total;
        }
    }
}
