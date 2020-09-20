using Microsoft.AspNetCore.Mvc;
using MVC.Test.IService;
using MVC.Test.Model.ttt_Entity;
using MVC.Test.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController:ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet(Name =nameof(GetStudent))]
        public async Task<List<Student>> GetStudent()
        {
            var list = await _service.Query();
            return list;
        }

     }
}
