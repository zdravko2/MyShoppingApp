using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppData.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public int RoleId { get; set; } = 0;
        //public int CartId { get; set; } = 0;
    }
}
