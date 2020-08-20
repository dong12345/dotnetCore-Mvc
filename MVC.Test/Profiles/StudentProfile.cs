using AutoMapper;
using MVC.Test.Model;
using MVC.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test.Profiles
{
    public class StudentProfile: Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentViewModel>()
                        .ForMember(dst => dst.TeacherName, x => x.MapFrom(src => src.Teacher.Name)).ReverseMap();

        }
    }
}
