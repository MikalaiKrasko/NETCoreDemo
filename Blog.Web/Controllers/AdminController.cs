using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.Logic;

namespace Blog.Web.Controllers
{
    //[Authorize] // any logged in user
    // [Authorize(Roles = "Admin")] // logged in user with administrator rights
    // https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-3.1
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        private IPostsManager _postsManager;

        // Dependency Injection через конструктор
        public AdminController(
            ILogger<AdminController> logger,
            IPostsManager productManager)
        {
            _logger = logger;
            _postsManager = productManager;
        }

        public IActionResult Posts()
        {
            string userId = "UserId";// Get id when authorization is ready 
            var model = _postsManager.GetPosts(userId);

            return View(model);           
        }
    }
}
