using Microsoft.AspNetCore.Identity;

namespace Neon.Web.Seeds
{
    public static class RoleSeed
    {
        public static IdentityRole[] Roles
        {
            get
            {
                return new IdentityRole[]
                {
                    new IdentityRole
                    {
                        Id = "CCD9FE14-EF0A-4B7F-9741-E7D968E0AB88",
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole
                    {
                        Id = "1C57C706-662C-46E7-8240-839F1A9ACD0C",
                        Name = "Author",
                        NormalizedName = "AUTHOR"
                    }
                };
            }
        }
    }
}
