using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ORM___Magazine.Model
{
    internal class StoreDbContext : DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<ProductType> ProductTypes { get; set; }
        public StoreDbContext() : base("StoreDbContext")
        {

        }
    }
}
