using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MVC.Test.Models;

namespace MVC.Test.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(Guid id)
        {
            return View();
        }
        public IActionResult Test()
        {
            var user = new User() { Name = "史育东", Age=17 };
            return View(user);
        }

        [HttpPost]
        public IActionResult Register([FromBody] User user,[FromQuery] string s,[FromHeader] string k,[FromRoute] string p)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
            }
            ViewBag.s = s;
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create()
        {
            ViewBag.name = Request.Form["Name"];
            return View();
        }

        [HttpPost]
        public IActionResult RegisterList([FromBody] List<User> user)
        {
            return View(user);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class User
    {
        [Required(ErrorMessage ="姓名为必填项")]
        public string Name { get; set; }

        [Required(ErrorMessage ="年龄为必填项")]
        public int Age { get; set; }
    }

}
