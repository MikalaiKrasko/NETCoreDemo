using Microsoft.EntityFrameworkCore;
using Ogorodik.DataProvider;
using Ogorodik.DataProvider.Models;
using Ogorodik.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Ogorodik.Logic
{
    public class OrderManager : IOrderManager
    {
        private OgorodikDbContext _db;

        public OrderManager(OgorodikDbContext context)
        {
            _db = context;
        }

        public List<OrderViewModel> GetOrders()
        {
            var allOrders = _db.Orders.AsNoTracking().ToList();

            var result = new List<OrderViewModel>();

            foreach (Order o in allOrders)
            {
                result.Add(new OrderViewModel { Name = o.Name, Phone = o.Phone });
            }

            return result;
        }
    }
}
