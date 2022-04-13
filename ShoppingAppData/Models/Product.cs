using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppData.Models
{
    public class Product : BaseEntity
    {
        public string Brand { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public string Specifications { get; set; } = String.Empty;
        public decimal Price { get; set; } = 0;
        public int CategoryId { get; set; } = -1;
        public int Promotion { get; set; } = 0;
        public Byte[] Thumbnail { get; set; } = new Byte[1];
    }
}
