using Autofac;
using Neon.Web.Entities;
using Neon.Web.Services.Category;
using static System.Formats.Asn1.AsnWriter;

namespace Neon.Web.Areas.Admin.Models.CategoryModels
{
    public class CategoryListModel
    {
        private ILifetimeScope _scope;
        private ICategoryService _categoryService;

        public List<Category> CategoryList { get; set; }

        public CategoryListModel() { }
        public CategoryListModel(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _categoryService = _scope.Resolve<ICategoryService>();
        }

        internal void GetCategories()
        {
            CategoryList = _categoryService.GetCategoryList();
        }

        internal void RemoveCategory(int id)
        {
            _categoryService.Remove(id);
        }
    }
}
