using System;
using efcore2.Models;
using efcore2.Services;
using System.Collections.Generic;

namespace efcore2.Responsitory
{
    public class ProductRespository : IProductResponsitory
    {
        private readonly ProductDbContext _productDbContext;
        public ProductRespository(ProductDbContext productDcContext)
        {
            _productDbContext = productDcContext;
        }
        public List<Product> GetProducts()
        {
            return _productDbContext.Products.ToList();
        }
        public void CreateProduct(Product pro)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                _productDbContext.Products.Add(pro);

                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
        public void UpdateProduct(Product pro)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                var productUpdate = _productDbContext.Products.Where(x => x.ProductID == pro.ProductID).FirstOrDefault();
                productUpdate.ProductName = pro.ProductName;
                productUpdate.Manufacture = pro.Manufacture;
                productUpdate.CategoryID = pro.CategoryID;
                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
        public void DeleteProduct(int id)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                var productDelete = _productDbContext.Products.Where(x => x.ProductID == id).FirstOrDefault();
                _productDbContext.Products.Remove(productDelete);
                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
    }
}