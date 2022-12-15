using Microsoft.AspNetCore.Mvc;

namespace Neon.Web.Controllers
{
    public class ErrorsController : Controller
    {
        [Route("errors/{statusCode:int}")]
        public IActionResult Index(int statusCode) => statusCode switch
        {
            404 => View("PageNotFound"),
            _ => View("ServerError")
        };
    }
}
