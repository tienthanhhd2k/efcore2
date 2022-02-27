using efcore2.Models;
using efcore2.Responsitory;
using System.Collections.Generic;

namespace efcore2.Services
{
    public class ProductServices : IProduct
    {
        private readonly IProductResponsitory _iResponsitory;
        public ProductServices(IProductResponsitory iResponsitory)
        {
            _iResponsitory = iResponsitory;
        }
        public List<Product> GetProducts()
        {
            return _iResponsitory.GetProducts();
        }
        public void CreateProduct(Product pro)
        {
            _iResponsitory.CreateProduct(pro);
        }
        public void UpdateProduct(Product pro)
        {
            _iResponsitory.UpdateProduct(pro);
        }
        public void DeleteProduct(int id)
        {
            _iResponsitory.DeleteProduct(id);
        }
    }
}