using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test.Models
{
    public class StudentViewModel
    {
        public Guid Id { get; set; }

        
        [Display(Name = "学生姓名")]
        [Required(ErrorMessage = "{0}字段为必填项")]
        public string Name { get; set; }

        [Display(Name="年龄")]
        public int Age { get; set; }

        [Display(Name = "教师姓名")]
        [Required]
        public string TeacherName { get; set; }
    }
}
