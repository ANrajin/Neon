using Neon.Web.Entities;

namespace Neon.Web.Seeds
{
    public static class CategoriesSeed
    {
        public static Category[] Categories
        {
            get
            {
                return new Category[]
                {
                    new Category
                    {
                        Id = 1,
                        Title = "Programming Languages",
                        UrlTitle = "programming-languages",
                        Description = "Lorem ipsum",
                        CreatedDate = new DateTime(2022, 12, 31)
                    },
                    new Category
                    {
                        Id = 2,
                        Title = "SOLID Principles",
                        UrlTitle = "solid-principles",
                        Description = "Lorem ipsum",
                        CreatedDate = new DateTime(2022, 12, 31)
                    },
                    new Category
                    {
                        Id = 3,
                        Title = "Frameworks",
                        UrlTitle = "frameworks",
                        Description = "Lorem ipsum",
                        CreatedDate = new DateTime(2022, 12, 31)
                    }
                };
            }
        }
    }
}
