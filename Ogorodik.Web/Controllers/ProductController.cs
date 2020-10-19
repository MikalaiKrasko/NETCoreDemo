using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ogorodik.Logic;
using Ogorodik.Web.Models;

namespace Ogorodik.Web.Controllers
{

    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        private IProductManager _productManager;

        // Dependency Injection через конструктор
        public ProductController(
            ILogger<ProductController> logger,
            IProductManager productManager)
        {
            _logger = logger;
            _productManager = productManager;
        }

        // [Authorize(Roles = "Administrator")] ограниченный доступ https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-3.1
        public IActionResult List()
        {
            var model = _productManager.GetProducts();

            return View(model);
           
        }
    }
}
