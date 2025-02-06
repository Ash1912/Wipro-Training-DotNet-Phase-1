using Day9Assignment1.Models;
using Day9Assignment1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day9Assignment1.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IUserService userService, ILogger<AccountController> logger)
        {
            _userService = userService;
            _logger = logger;
        }
        // GET: /Account/Register
        public IActionResult Register() => View();

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AccountViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (await _userService.Register(model.Username, model.Password))
            {
                _logger.LogInformation($"User {model.Username} registered successfully.");
                return RedirectToAction("Login");
            }

            ModelState.AddModelError("", "User already exists.");
            return View(model);
        }

        // GET: /Account/Login
        public IActionResult Login() => View();

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AccountViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (await _userService.Authenticate(model.Username, model.Password))
            {
                return RedirectToAction("Welcome");
            }

            ModelState.AddModelError("", "Invalid credentials.");
            return View(model);
        }

        // GET: /Account/Welcome
        public IActionResult Welcome() => View();
    }
}
