using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppData.Models
{
    public class Category : BaseEntity
    {
        public string Title { get; set; } = String.Empty;
        public Byte[] Thumbnail { get; set; } = new Byte[1];
    }
}
