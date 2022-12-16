using Microsoft.AspNetCore.Mvc;

namespace Neon.Web.Areas.Admin.Controllers
{
    public class PostsController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(string name)
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create()
        {
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
