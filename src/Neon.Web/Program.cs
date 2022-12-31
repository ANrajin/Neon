using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Neon.Web;
using Neon.Web.Data;
using Neon.Web.Entities.Member;
using Neon.Web.Services.Member;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

//Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new WebModule());
});

//Serilog
builder.Host.UseSerilog((ctx, lc) => lc
.MinimumLevel.Debug()
.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
.Enrich.FromLogContext()
.ReadFrom.Configuration(builder.Configuration));

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Custom identity
builder.Services.AddIdentity<ApplicationUser, Role>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddUserManager<UserManager>()
    .AddRoleManager<RoleManager>()
    .AddSignInManager<SignInManager>()
    .AddDefaultTokenProviders();

builder.Services.AddControllersWithViews();

//enforce route url to be in lowercase
builder.Services.Configure<RouteOptions>(opt =>
{
    opt.LowercaseUrls = true;
});

//Identity
builder.Services.Configure<IdentityOptions>(
    opts =>
    {
        opts.SignIn.RequireConfirmedEmail = false;
    });

builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = new PathString("/Account/Signin");
    opt.AccessDeniedPath = new PathString("/AccessDenied");
});

try
{
    var app = builder.Build();

    Log.Information("Successfully build your application");

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseMigrationsEndPoint();
        //exception page
        app.UseStatusCodePagesWithRedirects("/errors/{0}");
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}
catch(Exception Ex)
{
    Log.Fatal(Ex, "Application Start-up failed");
}
finally
{
    Log.CloseAndFlush();
}
