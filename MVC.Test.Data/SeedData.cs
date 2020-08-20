using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC.Test.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestDBContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<TestDBContext>>()))
            {
                if (context.Students.Any())
                {
                    return;
                }

                var id = Guid.NewGuid();
                context.Teachers.Add(new Teacher() { Id = id, Name = "张老师" });

                context.Students.AddRange(
                    new Student() { Name = "史育东", Age = 17,TeacherId= id },
                    new Student() { Name = "晓明", Age = 20,TeacherId= id }
                    );

                context.Movies.Add(new Movie()
                {
                    Genre = "test",
                    Price = 15.6M,
                    Title = "haha",
                    ReleaseDate = new DateTime().Date
                });
                context.SaveChanges();
            }
        }
    }
}
