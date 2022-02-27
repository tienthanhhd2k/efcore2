using efcore2.Models;
using efcore2.Responsitory;
using System.Collections.Generic;

namespace efcore2.Services
{
    public interface IProduct
    {
        public List<Product> GetProducts();
        public void CreateProduct(Product pro);
        public void UpdateProduct(Product pro);
        public void DeleteProduct(int id);
    }
}