using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.Model.ttt_Entity
{
    public class Student
    {
        [SugarColumn(IsPrimaryKey = true)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Guid? TeacherId { get; set; }
    }
}
