﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingAppData.Models;

namespace ShoppingApp.ViewInterfaces
{
    public interface IOrderView : IBaseView<Order>
    {
        User User { get; set; }
        Product Product { get; set; }
        int Quantity { get; set; }
    }
}
