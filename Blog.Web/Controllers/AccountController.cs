using Microsoft.AspNetCore.Mvc;
using Blog.ViewModels.Account;

namespace Blog.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // check if user exists and login, redirect to Home page
            //return View(); if user doesn't exists
            return RedirectToAction("index", "home");
        }
    }
}
