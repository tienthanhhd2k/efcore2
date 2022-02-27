using System;
using efcore2.Models;
using efcore2.Services;
using System.Collections.Generic;

namespace efcore2.Responsitory
{
    public interface IProductResponsitory
    {
        public List<Product> GetProducts();
        public void CreateProduct(Product pro);
        public void UpdateProduct(Product pro);
        public void DeleteProduct(int id);
    }
}