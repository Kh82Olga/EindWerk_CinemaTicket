using EindWerk_CinemaTicket.Data.Interfaces;
using EindWerk_CinemaTicket.Data.ShopCart;
using EindWerk_CinemaTicket.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMovie _movie;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrder _order;
        public OrdersController(IMovie movie, ShoppingCart shoppingCart, IOrder order)
        {
            _movie=movie;
            _shoppingCart=shoppingCart;
            _order=order;
        }

        public IActionResult ShoppingCart()
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
        public async Task <IActionResult> AddToShoppingCart(int id)
        {
            var item = await _movie.GetMovieByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.AddToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> RemoveFromShoppingCart(int id)
        {
            var item = await _movie.GetMovieByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.RemoveFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = "";
            string userEmail = "";

            await _order.StoreOrderAsync(items, userId, userEmail);
            await _shoppingCart.ClearShoppingCartAsync();
            return View("OrderCompleted");
        }
    }
}
