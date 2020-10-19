using Ogorodik.ViewModels;
using System.Collections.Generic;

namespace Ogorodik.Logic
{
    public interface IProductManager
    {
        List<ProductViewModel> GetProducts();
    }
}
