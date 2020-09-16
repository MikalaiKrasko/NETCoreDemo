using System.Diagnostics;
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


        public IActionResult List()
        {
            var model = _productManager.GetProducts();

            return View(model);
           
        }
    }
}
