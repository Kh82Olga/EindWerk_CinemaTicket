using EindWerk_CinemaTicket.Data;
using EindWerk_CinemaTicket.Data.ViewModels;
using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> AllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
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
        [HttpPost]
        public async Task<IActionResult>Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if (user !=null)
            {
                TempData["Error"] = "This mail address is already in use";
                return View(registerVM);
            }
            var newUser = new User()
            {
                UserName = registerVM.EmailAddress,
                Email = registerVM.EmailAddress,
                FullName = registerVM.FullName
            };
            var newUserResponse= await _userManager.CreateAsync(newUser,registerVM.Password);
            if (newUserResponse.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            }
            return View("RegisterCompleted");
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Movie");
        }
    }
}
