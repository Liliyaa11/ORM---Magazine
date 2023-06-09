using ORM___Magazine.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM___Magazine.Controller
{
    public class ProductTypeLogic
    {
        private StoreDbContext _storeDbContext = new StoreDbContext();
        public List<ProductType> GetAllBreeds()
        {
            return _storeDbContext.ProductTypes.ToList();
        }
        public string GetProductTypeById(int id)
        {
            return _storeDbContext.ProductTypes.Find(id).TypeName;
        }
    }
}
