using Autofac;
using Microsoft.AspNetCore.Mvc;
using Neon.Web.Areas.Admin.Models.PostModels;

namespace Neon.Web.Areas.Admin.Controllers
{
    public class PostsController : BaseController
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<CategoriesController> _logger;

        public PostsController(ILifetimeScope scope, ILogger<CategoriesController> logger)
        {
            _scope = scope;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var model = new PostCreateModel();
            _scope.Resolve<PostCreateModel>();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(PostCreateModel model)
        {
            //if (ModelState.IsValid)
            //{
                model.Resolve(_scope);

                try
                {
                    model.CreatePost();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            //}
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpDelete, ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
