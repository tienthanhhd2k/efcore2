using System;
using efcore2.Models;
using efcore2.Services;
using System.Collections.Generic;

namespace efcore2.Responsitory
{
    public class CategoryResponsitory : ICategoryResponsitory
    {
        private readonly ProductDbContext _productDbContext;
        private readonly IProductResponsitory _iProductResponsitory;
        public CategoryResponsitory(ProductDbContext productDcContext, IProductResponsitory iProductResponsitory)
        {
            _productDbContext = productDcContext;
            _iProductResponsitory = iProductResponsitory;
        }
        public List<Category> GetCategory()
        {
            return _productDbContext.Categories.ToList();
        }
        public void CreateCategory(Category cate)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                _productDbContext.Categories.Add(cate);

                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
        public void UpdateCategory(Category cate)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                var cateUpdate = _productDbContext.Categories.Where(x => x.CategoryId == cate.CategoryId).FirstOrDefault();
                cateUpdate.CategoryName = cate.CategoryName;
                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
        public void DeleteCategory(int id)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                var cateDelete = _productDbContext.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
                _productDbContext.Categories.Remove(cateDelete);
                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }


        }
        public ErrorRespone CreateProductAndCategory(Category cate, Product pro)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                _productDbContext.Categories.Add(cate);
                _productDbContext.SaveChanges();
                _productDbContext.Products.Add(pro);
                _productDbContext.SaveChanges();

                transaction.Commit();
                return new ErrorRespone()
                {
                    ErrorCode = 1,
                    ErrorMessage = "Success"
                };

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return new ErrorRespone()
                {
                    ErrorCode = 2,
                    ErrorMessage = ex.Message
                };
            }

        }
    }
}