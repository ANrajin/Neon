using Microsoft.AspNetCore.Mvc;

namespace Neon.Web.Controllers
{
    public class AccessDenied : Controller
    {
        public IActionResult Index() => View();
    }
}
