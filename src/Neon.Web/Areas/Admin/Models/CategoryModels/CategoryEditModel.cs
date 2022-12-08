using Autofac;
using Neon.Web.Entities;
using Neon.Web.Services;
using Neon.Web.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Neon.Web.Areas.Admin.Models.CategoryModels
{
    public class CategoryEditModel
    {
        private ICategoryService _categoryService;
        private ILifetimeScope _scope;

        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? UrlTitle { get; set; }
        public string Description { get; set; }

        public CategoryEditModel()
        {

        }

        public CategoryEditModel(ICategoryService categoryService,
    ILifetimeScope scope)
        {
            _categoryService = categoryService;
            _scope = scope;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _categoryService = _scope.Resolve<ICategoryService>();
        }

        internal void GetById(int id)
        {
            var data = _categoryService.GetById(id);

            Id = data.Id;
            Title = data.Title;
            UrlTitle = data.UrlTitle;
            Description = data.Description;
        }

        internal void Update()
        {
            var entity = new Category
            {
                Id = Id,
                Title = Title,
                UrlTitle = Title.Slug(),
                Description = Description,
                CreatedDate = DateTime.UtcNow
            };

            _categoryService.UpdateCategory(entity);
        }
    }
}
