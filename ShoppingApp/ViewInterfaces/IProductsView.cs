using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingAppData.Models;

namespace ShoppingApp.ViewInterfaces
{
    public interface IProductsView : IBaseView<Product>
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Specifications { get; set; }
        decimal Price { get; set; }
        Category Category { get; set; }
        int Promotion { get; set; }
        Byte[] Thumbnail { get; set; }
    }
}
