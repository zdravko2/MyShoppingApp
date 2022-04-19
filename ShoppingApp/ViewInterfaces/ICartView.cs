using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApp.ViewInterfaces;
using ShoppingAppData.Models;

namespace ShoppingApp.ViewInterfaces
{
    public interface ICartView : IBaseView<Cart>
    {
        User User { get; set; }
        Product Product { get; set; }
    }
}
