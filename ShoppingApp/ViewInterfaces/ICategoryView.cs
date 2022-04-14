using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingAppData.Models;

namespace ShoppingApp.ViewInterfaces
{
    public interface ICategoryView : IBaseView<Category>
    {
        string Title { get; set; }
        Byte[] Thumbnail { get; set; }
    }
}
