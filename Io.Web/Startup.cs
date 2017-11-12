using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Io.Config;
using Io.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;

namespace Io
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        .AddJsonFile($"appsecrets.json", optional: true)
        .AddEnvironmentVariables();

      //add keyVault secrets
      var config = builder.Build();
      builder.AddAzureKeyVault(
        $"https://{config["azureKeyVault:vault"]}.vault.azure.net/",
        config["azureKeyVault:clientId"],
        config["azureKeyVault:clientSecret"]);

      Configuration = builder.Build();
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      var config = Configuration.GetSection("appSettings").Get<AppConfig>();
      services.AddDbContext<IoDb>(opt => opt.UseSqlServer(config.ConnectionStrings.IoDb));
      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
        {
          HotModuleReplacement = true,
          ReactHotModuleReplacement = true
        });
      }
      else
      {
        app.UseRewriter(new RewriteOptions().AddRedirectToHttps());
        app.UseExceptionHandler("/Home/Error");        
      }

      

      app.UseStaticFiles();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");

        routes.MapSpaFallbackRoute(
                  name: "spa-fallback",
                  defaults: new { controller = "Home", action = "Index" });
      });
    }
  }
}
