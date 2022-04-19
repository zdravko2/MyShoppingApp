using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppData.Models
{
    public class Cart : BaseEntity
    {
        public User User { get; set; } = new User();
        public Product Product { get; set; } = new Product();
    }
}
