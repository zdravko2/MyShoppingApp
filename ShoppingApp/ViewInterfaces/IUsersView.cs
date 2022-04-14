using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingAppData.Models;

namespace ShoppingApp.ViewInterfaces
{
    public interface IUsersView : IBaseView<User>
    {
        string Username { get; set; }
        int RoleId { get; set; }
    }
}
