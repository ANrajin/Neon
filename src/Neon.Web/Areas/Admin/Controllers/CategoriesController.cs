using Autofac;
using Microsoft.AspNetCore.Mvc;
using Neon.Web.Areas.Admin.Models.CategoryModels;

namespace Neon.Web.Areas.Admin.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILifetimeScope scope, ILogger<CategoriesController> logger)
        {
            _scope = scope;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = _scope.Resolve<CategoryListModel>();
            model.GetCategories();
            return View(model);
        }

        public IActionResult Create()
        {
            var model = _scope.Resolve<CategoryCreateModel>();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(CategoryCreateModel model)
        {
            model.Resolve(_scope);

            if(ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    _logger.LogInformation("Category successfully created!");

                    return RedirectToAction("Create");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Cannot create the category! Something went wrong");
                }
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _scope.Resolve<CategoryEditModel>();
            model.GetById(id);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryEditModel model)
        {
            model.Resolve(_scope);

            if(ModelState.IsValid)
            {
                try
                {
                    model.Update();

                    _logger.LogInformation("Category successfully updated!");
                }
                catch(Exception ex)
                {
                    _logger.LogError(ex, "Cannot create the category! Something went wrong");
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = _scope.Resolve<CategoryListModel>();
            model.RemoveCategory(id);

            return RedirectToAction("Index");
        }
    }
}
