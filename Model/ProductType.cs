using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM___Magazine.Model
{
    public class ProductType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        ICollection<Product>Products { get; set; }
    }
}
