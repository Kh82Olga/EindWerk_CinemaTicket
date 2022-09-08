using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Data.ShopCart;
using EindWerk_CinemaTicket.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EindWerk_CinemaTicket.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMovie _movie;
        private readonly ShoppingCart _shoppingCart;
        public OrdersController(IMovie movie, ShoppingCart shoppingCart)
        {
            _movie=movie;
            _shoppingCart=shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var result = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetTotal()
            };
            return View(result);
        }
    }
}
