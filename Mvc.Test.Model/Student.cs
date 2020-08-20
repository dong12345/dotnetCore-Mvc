using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVC.Test.Model
{
    public  class Student
    {
        [Key]
        public Guid Id { get; set; }

        //[StringLength(500)]
        [Column(TypeName ="varchar(250)")]
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public Teacher Teacher { get; set; }

        [ForeignKey(name:"Teacher")]
        public Guid TeacherId { get; set; }


    }
}
