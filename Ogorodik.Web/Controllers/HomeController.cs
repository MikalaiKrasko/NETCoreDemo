using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ogorodik.Logic;
using Ogorodik.Web.Models;

namespace Ogorodik.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IOrderManager _orderManager;

        // Dependency Injection через конструктор
        public HomeController(ILogger<HomeController> logger,
            IOrderManager orderManager)
        {
            _logger = logger;
            _orderManager = orderManager;
        }

        public IActionResult Index()
        {
            var model = _orderManager.GetOrders();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
