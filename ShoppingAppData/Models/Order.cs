using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppData.Models
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; } = -1;
        public int ProductId { get; set; } = -1;
        public int Quantity { get; set; } = 0;
    }
}
