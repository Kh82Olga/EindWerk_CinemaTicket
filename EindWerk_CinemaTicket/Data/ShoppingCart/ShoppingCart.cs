﻿using EindWerk_CinemaTicket.Models;
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
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId)
                .Include(n => n.Movie).ToList());
        }
    }
}
