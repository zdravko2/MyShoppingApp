using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingAppData.Models;

namespace ShoppingApp.ViewInterfaces
{
    public interface IBaseView<T> where T : BaseEntity
    {
        void DisplayInfo(T product);
        int Id { get; set; }
    }
}
