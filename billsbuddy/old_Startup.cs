using billsbuddy.Data;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class old_Startup
{
    public IConfigurationRoot Configuration { get; private set; }

    public void ConfigureServices(IServiceCollection services)
    {
        //// Add services to the dependency injection container
        //services.AddMvc(); // Example: Adding MVC services
        //services.AddTransient<IMyService, MyService>(); // Example: Adding a custom service
        var builder = new ConfigurationBuilder()
                .AddEnvironmentVariables(); // <--- This picks up env variables
        Configuration = builder.Build();
    }

    //public Startup(IHostingEnvironment env)
    //{
    //    var builder = new ConfigurationBuilder()
    //            .AddEnvironmentVariables(); // <--- This picks up env variables
    //    Configuration = builder.Build();
    //}.
//}
//public class Startup
//{
//    public Startup(IConfiguration configuration)
//    {
//        Configuration = configuration;
//    }

//    public IConfiguration Configuration { get; }

//    // This method gets called by the runtime. Use this method to add services to the container.
//    public void ConfigureServices(IServiceCollection services)
//    {
//        services.AddDbContext<ApplicationDbContext>(options =>
//            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

//        services.AddIdentity<ApplicationUser, IdentityRole>()
//            .AddEntityFrameworkStores<ApplicationDbContext>()
//            .AddDefaultTokenProviders();

//        // Add application services.
//        services.AddTransient<IEmailSender, EmailSender>();

//        services.AddMvc();

//        // Add http context
//        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
//    }

//    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//    {
//        if (env.IsDevelopment())
//        {
//            app.UseBrowserLink();
//            app.UseDeveloperExceptionPage();
//            app.UseDatabaseErrorPage();
//        }
//        else
//        {
//            app.UseExceptionHandler("/Home/Error");
//        }

//        app.UseStaticFiles();

//        app.UseAuthentication();

//        app.UseMvc(routes =>
//        {
//            routes.MapRoute(
//                name: "default",
//                template: "{controller=Home}/{action=Index}/{id?}");
//        });
//    }
//}