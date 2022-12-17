using System.Security.Claims;
using Autofac;
using Neon.Web.Entities;
using Neon.Web.Enums;
using Neon.Web.Services.Post;
using Neon.Web.Utilities;

namespace Neon.Web.Areas.Admin.Models.PostModels
{
    public class PostCreateModel
    {
        private IPostService _postService;
        private ILifetimeScope _scope;
        private IHttpContextAccessor _contextAccessor;

        public PostCreateModel()
        {
        }

        public PostCreateModel(IPostService postService, 
            ILifetimeScope scope, 
            IHttpContextAccessor contextAccessor)
        {
            _postService = postService;
            _scope = scope;
            _contextAccessor = contextAccessor;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Guid UserId { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public PostStatus Status { get; set; }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _postService = _scope.Resolve<IPostService>();
            _contextAccessor = _scope.Resolve<IHttpContextAccessor>();
        }

        public void CreatePost()
        {
            Post entity = new()
            {
                Title = Title,
                Slug = Title.Slug(),
                Description = Description,
                UserId = Guid.Parse(_contextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value!),
                CategoryId = CategoryId,
                Status = Status,
                CreatedAt = DateTime.UtcNow
            };

            _postService.Create(entity);
        }
    }
}
