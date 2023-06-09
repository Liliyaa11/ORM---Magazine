using ORM___Magazine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM___Magazine.Controller
{
    public class ProductLogic
    {
        private StoreDbContext _storeDbContext = new StoreDbContext();
        public Product Get(int id)
        {
            Product findedDog = _storeDbContext.Products.Find(id); if (findedDog != null)
            {
                _storeDbContext.Entry(findedDog).Reference(x => x.ProductTypes).Load();
            }
            return findedDog;
        }
        public List<Product> GetAll()
        {
            return _storeDbContext.Products.Include("ProductTypes").ToList();
        }
        public void Create(Product product)
        {
            _storeDbContext.Products.Add(product);
            _storeDbContext.SaveChanges();
        }
        public void Update(int id, Product product)
        {
            Product findedProduct = _storeDbContext.Products.Find(id);
            if (findedProduct == null) //
            {
                return;
            }
            findedProduct.Brand = product.Brand;
            findedProduct.Price = product.Price;
            findedProduct.ProductTypesId = product.ProductTypesId;
            _storeDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Product findedProduct = _storeDbContext.Products.Find(id);
            _storeDbContext.Products.Remove(findedProduct);
            _storeDbContext.SaveChanges();
        }
    }
}
