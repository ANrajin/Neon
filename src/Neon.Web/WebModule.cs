using Autofac;
using Neon.Web.Areas.Admin.Models.CategoryModels;
using Neon.Web.Areas.Admin.Models.PostModels;
using Neon.Web.Services.Category;
using Neon.Web.Services.Post;

namespace Neon.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //models
            builder.RegisterType<CategoryCreateModel>().AsSelf();
            builder.RegisterType<CategoryListModel>().AsSelf();
            builder.RegisterType<CategoryEditModel>().AsSelf();

            builder.RegisterType<PostCreateModel>().AsSelf();
            builder.RegisterType<PostListModel>().AsSelf();
            builder.RegisterType<PostEditModel>().AsSelf();

            //services
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<PostService>().As<IPostService>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
