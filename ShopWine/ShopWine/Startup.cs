using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopWine_BLL.Infrastructure;
using ShopWine_BLL.Infrastructure.Provider;
using ShopWine_BLL.Services;
using ShopWine_BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWine
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
            BllConfiguration.Configuration(services, Configuration.GetConnectionString("defCon"));

            var option = new SendGridOptions();
            Configuration.GetSection("SendGridOptions").Bind(option);
            services.AddTransient<SendGridOptions>(x => option);
            //services.Configure<SendGridOptions>(op => Configuration.GetSection("SendGridOptions"));

            services.AddTransient<IEmailSender, EmailSender>();
           // services.Configure<EmailConfirmationProviderOption>(op => op.TokenLifespan = TimeSpan.FromMinutes(15));

            services.AddAuthentication().AddCookie(op => op.LoginPath = "/Login");

            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
