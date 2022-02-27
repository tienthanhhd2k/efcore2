using efcore2.Models;
using efcore2.Responsitory;
using System.Collections.Generic;

namespace efcore2.Services
{
    public class CategoryServices : ICategory
    {
        private readonly ICategoryResponsitory _iCategoryResponsitory;

        public CategoryServices(ICategoryResponsitory iCategoryResponsitory)
        {
            _iCategoryResponsitory = iCategoryResponsitory;

        }
        public List<Category> GetCategory()
        {
            return _iCategoryResponsitory.GetCategory();
        }
        public void CreateCategory(Category cate)
        {
            _iCategoryResponsitory.CreateCategory(cate);
        }

        public void UpdateCategory(Category cate)
        {
            _iCategoryResponsitory.UpdateCategory(cate);
        }
        public void DeleteCategory(int id)
        {
            _iCategoryResponsitory.DeleteCategory(id);
        }

        public ErrorRespone CreateProductAndCategory(Category cate, Product pro)
        {
            return _iCategoryResponsitory.CreateProductAndCategory(cate, pro);
        }
    }
}