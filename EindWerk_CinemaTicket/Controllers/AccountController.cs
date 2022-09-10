using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.ViewModels;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        [HttpPost]
        public async Task<IActionResult>Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var paswordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (paswordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password,false,false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Movie");
                    }   
                }
                TempData["Error"] = "Wrong! Please try again.";
                return View(loginVM);
            }
            TempData["Error"] = "Wrong! Please try again.";
            return View(loginVM);
        }
        public IActionResult Register()
        {
            var result = new RegisterVM();
            return View(result);
        }
    }
}
