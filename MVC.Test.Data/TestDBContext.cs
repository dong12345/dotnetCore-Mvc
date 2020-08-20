using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVC.Test.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.Data
{
    public class TestDBContext : DbContext
    {

        public TestDBContext()
        {

        }
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(ConsoloLogggerFactory);
            //optionsBuilder.UseLoggerFactory(ConsoloLogggerFactory)
            //    .UseSqlServer(@"Server=.;Database=MVCTest;Integrated Security=True");
        }
       public static readonly ILoggerFactory ConsoloLogggerFactory =
        LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) =>
                 category == DbLoggerCategory.Database.Command.Name
                 && level == LogLevel.Information)
                .AddConsole();
        });

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Movie> Movies { get; set; }
    }
}
