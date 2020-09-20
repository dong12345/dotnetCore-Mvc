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
                //������ʾ��������,���ɵ�sql����п��Կ��������ľ���ֵ
                options.EnableSensitiveDataLogging(true);
                options.UseSqlServer("Server=.;Database=ttt;Integrated Security=True");
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;//��ȡ��Ŀ·��
            basePath = basePath.Replace("netcoreapp3.1", "netstandard2.0");
            var servicesDllFile = Path.Combine(basePath, "MVC.Test.Service.dll");//��ȡע����Ŀ����·��
            var assemblysServices = Assembly.LoadFile(servicesDllFile);//ֱ�Ӳ��ü����ļ��ķ���

            builder.RegisterGeneric(typeof(EFBaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();//ע��ִ�

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