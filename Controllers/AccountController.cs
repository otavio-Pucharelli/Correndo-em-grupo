using CorrendoEmGrupo.Data;
using CorrendoEmGrupo.Models;
using CorrendoEmGrupo.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CorrendoEmGrupo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            var response = new LoginViewModel();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "Club");
                    }
                }
                TempData["Error"] = "credenciais erradas";
                return View(loginViewModel);
            }
            TempData["Error"] = "credenciais erradas";
            return View(loginViewModel);
        }

        public IActionResult Register()
        {
            var response = new LoginViewModel();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel RegisterViewModel)
        {
            if (!ModelState.IsValid) return View(RegisterViewModel);

            var user = await _userManager.FindByEmailAsync(RegisterViewModel.EmailAddress);
            if(user != null) 
            {
                TempData["Error"] = "Esse endereço de email ja esta em uso";
                return View(RegisterViewModel);
            }

            var newUser = new AppUser()
            {
                Email = RegisterViewModel.EmailAddress,
                UserName = RegisterViewModel.EmailAddress
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, RegisterViewModel.Password);
            if (newUserResponse.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            }

            return View("Home");
        }
        //teste
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Race");
        }
    }
}
