using Neon.Web.Entities.Member;

namespace Neon.Web.Seeds
{
    public static class RoleSeed
    {
        public static Role[] Roles
        {
            get
            {
                return new Role[]
                {
                    new Role
                    {
                        Id = Guid.Parse("CCD9FE14-EF0A-4B7F-9741-E7D968E0AB88"),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                        ConcurrencyStamp = "6A6F0469-939D-4F04-84BD-7469C7F84120"
                    },
                    new Role
                    {
                        Id = Guid.Parse("1C57C706-662C-46E7-8240-839F1A9ACD0C"),
                        Name = "Author",
                        NormalizedName = "AUTHOR",
                        ConcurrencyStamp = "52D1D3ED-4B63-44FD-89B0-7380F49F6DDA"
                    }
                };
            }
        }
    }
}
