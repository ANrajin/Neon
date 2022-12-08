using Autofac;
using Neon.Web.Entities;
using Neon.Web.Services;
using Neon.Web.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Neon.Web.Areas.Admin.Models.CategoryModels
{
    public class CategoryCreateModel
    {
        private ICategoryService _categoryService;
        private ILifetimeScope _scope;

        [Required]
        public string Title { get; set; }
        public string? UrlTitle { get; set; }
        public string Description { get; set; }

        public CategoryCreateModel()
        {

        }

        public CategoryCreateModel(ICategoryService categoryService,
            ILifetimeScope scope)
        {
            _categoryService= categoryService;
            _scope= scope;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope= scope;
            _categoryService = _scope.Resolve<ICategoryService>();
        }

        internal void Create()
        {
            var entity = new Category
            {
                Title = Title,
                UrlTitle = Title.Slug(),
                Description = Description,
                CreatedDate = DateTime.UtcNow
            };

            _categoryService.CreateCategory(entity);
        }
    }
}
