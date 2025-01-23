using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class AuthController : Controller
    {
        // Display Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Handle Login Submission
        [HttpPost]
        public IActionResult Login(User user)
        {
            // Hardcoded credentials for simplicity
            string validUsername = "admin";
            string validPassword = "password";

            if (user.Username == validUsername && user.Password == validPassword)
            {
                // Redirect to a welcome page if login is successful
                TempData["Message"] = "Login successful!";
                return RedirectToAction("Welcome");
            }
            
            // Stay on the login page if invalid credentials
            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        // Welcome Page
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
