using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC.Test.Data;
using MVC.Test.IService.test;

namespace MVC.Test
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            var param = Configuration.GetConnectionString("param");

            services.AddDbContextPool<TestDBContext>(options => {
                //启用显示敏感数据,生成的sql语句中可以看到参数的具体值
                options.EnableSensitiveDataLogging(true);
                options.UseSqlServer(Configuration.GetConnectionString("myConnectionString"));
            });
            //services.AddDbContext<TestDBContext>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddAntiforgery(options =>
            {
                // Set Cookie properties using CookieBuilder properties†
                options.FormFieldName = "AntiforgeryKey_shiyudong";
                //options.HeaderName = "X-CSRF-TOKEN-shiyudong";
                options.SuppressXFrameOptionsHeader = false;
            });


            //services.AddSingleton<ISingTest, SingTest>();
            //services.AddScoped<ISconTest, SconTest>();
            //services.AddTransient<ITranTest, TranTest>();
            //services.AddScoped<IAService, AService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=student}/{action=Index}/{id?}");
            });
        }
    }
}
