using Neon.Web.Data;

namespace Neon.Web.Services
{
    public abstract class Service
    {
        protected readonly ApplicationDbContext _context;

        protected Service(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
