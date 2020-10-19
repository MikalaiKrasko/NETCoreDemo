using Ogorodik.ViewModels;
using System.Collections.Generic;

namespace Ogorodik.Logic
{
    public interface IOrderManager
    {
        List<OrderViewModel> GetOrders();
    }
}