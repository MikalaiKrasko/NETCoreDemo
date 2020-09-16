﻿using Ogorodik.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ogorodik.Logic
{
    public interface IOrderManager
    {
        List<OrderViewModel> GetOrders();
    }
}