using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Test.Data;
using MVC.Test.Helper;
using MVC.Test.Model;
using MVC.Test.Models;
using MVC.Test.Profiles;
using Newtonsoft.Json;

namespace MVC.Test.Controllers
{
    public class StudentController : Controller
    {
        private readonly TestDBContext _context;
        private readonly IMapper _mapper;

        public StudentController(TestDBContext context, IMapper mapper)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            this._context = context;
            this._mapper = mapper;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "学生列表页";
            return View();
        }

        public IActionResult GetAllStudent()
        {
            var studentList = _context.Students.Include(x => x.Teacher).ToList();
            var studentVMList = _mapper.Map<List<StudentViewModel>>(studentList);
            var data = new
            {
                code = 0,
                msg = "",
                count = studentVMList.Count,
                data = studentVMList
            };
            return Ok(data);
        }

        public IActionResult GetStudent(Guid? id)
        {
            if (id == Guid.Empty || id == null)
            {
                return NotFound();
            }
            var stu = _context.Students.FirstOrDefault(s => s.Id == id);
            if (stu == null)
            {
                return NotFound();
            }
            var studentVM = _mapper.Map<StudentViewModel>(stu);
            return View(studentVM);

        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var stu = _mapper.Map<Student>(model);
            if (!string.IsNullOrEmpty(model.TeacherName))
            {
                var teacher = _context.Teachers.FirstOrDefault(x => x.Name == model.TeacherName);
                var teacherId = Guid.NewGuid();
                if (teacher != null)
                {
                    teacherId = teacher.Id;
                    stu.Teacher = null;
                }
                else
                {
                    stu.Teacher.Id = teacherId;
                }
                stu.TeacherId = teacherId;
                _context.AddRange(stu);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stu = await _context.Students.Include(x => x.Teacher).FirstOrDefaultAsync(x=>x.Id==id);
            if (stu == null)
            {
                return NotFound();
            }
            var stuVM = _mapper.Map<StudentViewModel>(stu);
            return View(stuVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var id = model.Id;
            var stu= await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stu == null)
            {
                return NotFound();
            }

            stu.Name = model.Name;
            stu.Age = model.Age;
            await _context.SaveChangesAsync();
            return Ok(new { code = 200, message = "成功" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([ModelBinder(BinderType = typeof(GuidHeaderModelBinder))] Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var stu = await _context.Students.SingleOrDefaultAsync(x => x.Id == id);
            _context.Students.Remove(stu);
            await _context.SaveChangesAsync();
            return Json(new { code = 200, message = "删除成功", isSuccess = true });
        }


        //[HttpPost]
        ////[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Delete([FromForm]string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //var stu = await _context.Students.SingleOrDefaultAsync(x => x.Id == id);
        //    //_context.Students.Remove(stu);
        //    //await _context.SaveChangesAsync();
        //    return Json(new { code = 200, message = "删除成功", isSuccess = true });
        //}


    }
}