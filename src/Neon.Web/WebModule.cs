using Autofac;
using Neon.Web.Areas.Admin.Models.CategoryModels;
using Neon.Web.Services;

namespace Neon.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryCreateModel>().AsSelf();
            builder.RegisterType<CategoryListModel>().AsSelf();
            builder.RegisterType<CategoryEditModel>().AsSelf();
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
