using Autofac;
using Autofac.Extras.DynamicProxy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC.Test.IRepository;
using MVC.Test.IRepository.Base;
using MVC.Test.IService;
using MVC.Test.Repository;
using MVC.Test.Repository.Base;
using MVC.Test.Repository.EF;
using MVC.Test.Service;
using System.IO;
using System.Reflection;

namespace MVC.Test.Api
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
            services.AddControllers();

            services.AddDbContext<EFDBContext>(options =>
            {
                //启用显示敏感数据,生成的sql语句中可以看到参数的具体值
                options.EnableSensitiveDataLogging(true);
                options.UseSqlServer("Server=.;Database=ttt;Integrated Security=True");
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;//获取项目路径
            basePath = basePath.Replace("netcoreapp3.1", "netstandard2.0");
            var servicesDllFile = Path.Combine(basePath, "MVC.Test.Service.dll");//获取注入项目绝对路径
            var assemblysServices = Assembly.LoadFile(servicesDllFile);//直接采用加载文件的方法

            builder.RegisterGeneric(typeof(EFBaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();//注册仓储

            builder.RegisterType<StudentService>().As<IStudentService>();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();

            builder.RegisterAssemblyTypes(assemblysServices)
                      .AsImplementedInterfaces()
                      .InstancePerLifetimeScope()
                      .EnableInterfaceInterceptors();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}