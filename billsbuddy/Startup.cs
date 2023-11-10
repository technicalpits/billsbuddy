using FluentAssertions.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
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
}
