using Microsoft.AspNetCore.Mvc;
using MVC.Test.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EFController:ControllerBase
    {
        private readonly EFDBContext _context;

        public EFController(EFDBContext context)
        {
            _context = context;
        }

        public void GetStudents()
        {
            var list= _context.Student.ToList();
        }
    }
}
