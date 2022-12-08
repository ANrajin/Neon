using Neon.Web.Entities;

namespace Neon.Web.Services
{
    public interface ICategoryService
    {
        void CreateCategory(Category entity);
        Category GetById(int id);
        List<Category> GetCategoryList();
        void Remove(int id);
        void UpdateCategory(Category entity);
    }
}
