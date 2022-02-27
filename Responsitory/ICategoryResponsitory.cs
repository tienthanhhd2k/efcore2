using System;
using efcore2.Models;
using efcore2.Services;
using System.Collections.Generic;

namespace efcore2.Responsitory
{
    public interface ICategoryResponsitory
    {
        public List<Category> GetCategory();
        public void CreateCategory(Category cate);
        public void UpdateCategory(Category cate);
        public void DeleteCategory(int id);
        public ErrorRespone CreateProductAndCategory(Category cate, Product pro);
    }
}