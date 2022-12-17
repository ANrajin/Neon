using Autofac;
using Neon.Web.Services.Post;

namespace Neon.Web.Areas.Admin.Models.PostModels
{
    public class PostEditModel
    {
        private IPostService _postService;
        private ILifetimeScope _scope;

        public PostEditModel()
        {

        }

        public PostEditModel(IPostService postService, ILifetimeScope scope)
        {
            _postService = postService;
            _scope = scope;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _postService = _scope.Resolve<IPostService>();
        }
    }
}
