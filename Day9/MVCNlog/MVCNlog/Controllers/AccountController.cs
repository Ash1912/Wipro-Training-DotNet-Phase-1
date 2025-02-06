using Microsoft.AspNetCore.Mvc;
using MVCNlog.Services;
using NLog;

namespace MVCNlog.Controllers
{
    public class AccountController : Controller
    {
        private readonly NLog.ILogger _logger;
        private readonly UserService _userService;

        // Inject UserService into the controller
        public AccountController(UserService userService)
        {
            _userService = userService;
            _logger = LogManager.GetCurrentClassLogger();
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(string username, string password)
        {
            try
            {
                // Attempt to register the user
                bool registrationSuccess = await _userService.Register(username, password);

                if (registrationSuccess)
                {
                    _logger.Info($"User {username} registered successfully.");
                    return RedirectToAction("Login"); //goto action method login - return view for login
                }
                else
                {
                    _logger.Warn($"User {username} already exists.");
                    ModelState.AddModelError("", "User already exists.");
                    return View();
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.Error(ex, "Error occurred while registering user.");

                // Optionally, add a model error and return to the registration view
                ModelState.AddModelError("", "An error occurred during registration.");
                return View();
            }
        }

        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                bool loginSuccess = await _userService.Authenticate(username, password);
                if (loginSuccess)
                {
                    // Redirect to a welcome page or user dashboard after successful login
                    return RedirectToAction("Welcome");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }
            return View();
        }

        // GET: /Account/Welcome
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
