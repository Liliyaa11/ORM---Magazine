using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM___Magazine.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DateTime { get; set; }
        public int ProductTypesId { get; set; }
        public ProductType ProductTypes { get; set; }

    }
}
