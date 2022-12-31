using Microsoft.AspNetCore.Identity;
using Neon.Web.Entities.Member;

namespace Neon.Web.Seeds
{
    public static class AdminSeed
    {
        public static ApplicationUser Users
        {
            get
            {
                var user = new ApplicationUser
                {
                    Id = Guid.Parse("B9CB67F7-02CC-4EAD-9874-7CD9A589935F"),
                    FirstName = "Super",
                    LastName = "Admin",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@neon.com",
                    NormalizedEmail = "ADMIN@NEON.COM",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PhoneNumber = "01782044014",
                    ConcurrencyStamp = "70025A6E-E282-4F03-BD99-9578C3895334",
                    AccessFailedCount = 0,
                    LockoutEnabled = false,
                    LockoutEnd = new DateTime(2022, 12, 31),
                    PasswordHash = "AQAAAAEAACcQAAAAEFRWEmRJXlkqidHuaXRKu6PDZdeUB2z3ScEdA2glTbr6NWo3uFiTDf4BbyRsIxC0yg=="
                };

                return user;
            }
        }

        public static UserRole UserRole => new()
        {
            RoleId = Guid.Parse("CCD9FE14-EF0A-4B7F-9741-E7D968E0AB88"),
            UserId = Guid.Parse("B9CB67F7-02CC-4EAD-9874-7CD9A589935F")
        };
    }
}
