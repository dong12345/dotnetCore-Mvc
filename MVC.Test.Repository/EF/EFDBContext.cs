using Microsoft.EntityFrameworkCore;
using MVC.Test.Model.ttt_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.Repository.EF
{
    public class EFDBContext: DbContext
    {
        public EFDBContext()
        {

        }
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.;Database=ttt;Integrated Security=True");
        }

        public DbSet<Student> Student { get; set; }
    }
}
