using EindWerk_CinemaTicket.Data.ShopCart;
using Microsoft.AspNetCore.Mvc;

namespace EindWerk_CinemaTicket.Data.ViewComponents
{
    public class CartSummary:ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public CartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart=shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            return View(items.Count);
        }
    }
}
