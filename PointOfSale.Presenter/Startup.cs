using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PointOfSale.Application;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;

namespace PointOfSale.Presenter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var pointOfSalseConnectionString = Configuration["PointOfSale:ConnectionString"];
            
            services.AddDbContext<PointOfSaleDbContext>(
                option =>
                {
                    option.UseSqlServer(pointOfSalseConnectionString);
                });

            services.AddApplicationInitialization();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) //Authentication scheme is the authentication configuration
            //    .AddCookie(o=> o.LoginPath= "/api/account/login"); //cookies as default

            services.AddControllers();
            //    .AddNewtonsoftJson(options =>
            //{
            //    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("", async appBuilder =>
                {
                    await appBuilder.Response.WriteAsync("Point of sale API");
                });

                endpoints.MapControllers();

            });
        }
    }
}
