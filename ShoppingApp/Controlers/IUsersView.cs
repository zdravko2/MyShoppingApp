using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingApp.Controlers;
using ShoppingAppData.Models;

namespace ShoppingApp.Controlers
{
    public interface IUsersView : IBaseView<User>
    {
        string Username { get; set; }
        string Password { get; set; }
        int Role { get; set; }
    }
}
