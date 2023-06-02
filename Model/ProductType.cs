using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM___Magazine.Model
{
    internal class ProductType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        ICollection<Products>Products { get; set; }
    }
}
