using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Neon.Web.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class BaseController : Controller
    {
    }
}
