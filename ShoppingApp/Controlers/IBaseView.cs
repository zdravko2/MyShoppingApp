using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingAppData.Models;

namespace ShoppingApp.Controlers
{
    public interface IBaseView<T> where T : BaseEntity
    {
        void DisplayInfo(T product);
        //void EditInfo();
        int Id { get; set; }
    }
}
