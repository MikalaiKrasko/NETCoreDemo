using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ogorodik.Logic;

namespace Ogorodik.Web.Controllers
{
    [Authorize] // any logged in user
    // [Authorize(Roles = "Admin")] // logged in user with administrator rights
    // https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-3.1
    public class AdminController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        private IProductManager _productManager;

        // Dependency Injection через конструктор
        public AdminController(
            ILogger<ProductController> logger,
            IProductManager productManager)
        {
            _logger = logger;
            _productManager = productManager;
        }

        public IActionResult Products()
        {
            var model = _productManager.GetProducts();

            return View(model);           
        }
    }
}
