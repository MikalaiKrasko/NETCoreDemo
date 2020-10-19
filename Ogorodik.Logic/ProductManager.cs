using Microsoft.EntityFrameworkCore;
using Ogorodik.DataProvider;
using Ogorodik.DataProvider.Models;
using Ogorodik.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Ogorodik.Logic
{
    public class ProductManager : IProductManager
    {
        private OgorodikDbContext _db;

        public ProductManager(OgorodikDbContext context)
        {
            _db = context;
        }

        public List<ProductViewModel> GetProducts()
        {
            var allProducts = _db.Products.AsNoTracking().ToList();

            var result = new List<ProductViewModel>();

            foreach (Product o in allProducts)
            {
                result.Add(new ProductViewModel { Name = o.Name });
            }

            return result;
        }
    }
}