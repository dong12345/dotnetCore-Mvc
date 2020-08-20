using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MVC.Test.Model
{
    public  class Teacher
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public Teacher()
        {
            Students = new List<Student>() { };
        }
    }
}
