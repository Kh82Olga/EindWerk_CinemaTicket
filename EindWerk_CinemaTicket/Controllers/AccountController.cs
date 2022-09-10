using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.ViewModels;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EindWerk_CinemaTicket.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _context;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,
            AppDbContext context)
        {
            _userManager=userManager;
            _signInManager=signInManager;
            _context=context;
        }
        public IActionResult Login()
        {
            var result = new LoginVM();
            return View(result);
        }
    }
}
