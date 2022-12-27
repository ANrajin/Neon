using System.Diagnostics;
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
        private IWebHostEnvironment _webHostEnvironment;

        public PostCreateModel()
        {
        }

        public PostCreateModel(IPostService postService,
            ILifetimeScope scope,
            IHttpContextAccessor contextAccessor,
            IWebHostEnvironment webHostEnvironment)
        {
            _postService = postService;
            _scope = scope;
            _contextAccessor = contextAccessor;
            _webHostEnvironment = webHostEnvironment;
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
            _webHostEnvironment = _scope.Resolve<IWebHostEnvironment>();
        }

        public void CreatePost()
        {
            Post entity = new()
            {
                Title = Title,
                Slug = Title.Slug(),
                Description = Description,
                UserId = Guid.Parse(_contextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value!),
                CategoryId = 1,
                Image = PostImage(),
                Status = 0,
                CreatedAt = DateTime.UtcNow
            };

            _postService.Create(entity);
        }

        private string PostImage()
        {
            var filename = ImageFile.FileName;
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images");

            if(ImageFile.Length> 0)
            {
                using var ms = new MemoryStream();
                {
                    ImageFile.CopyTo(ms);

                    using var stream = new FileStream(Path.Combine(path, filename), FileMode.Create);
                    {
                        ImageFile.CopyTo(stream);
                    }
                }
            }

            return filename;
        }
    }
}
