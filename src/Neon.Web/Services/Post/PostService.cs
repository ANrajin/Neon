using Neon.Web.Data;

namespace Neon.Web.Services.Post
{
    public class PostService : Service, IPostService
    {
        public PostService(ApplicationDbContext context) : base(context)
        {
        }

        public void Create(Entities.Post entity)
        {
            _context.Posts.Add(entity);
            _context.SaveChanges();
        }
    }
}
