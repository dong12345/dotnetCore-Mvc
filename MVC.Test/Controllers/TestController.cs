using Microsoft.AspNetCore.Mvc;
using MVC.Test.IService.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController:ControllerBase
    {
        private readonly ISingTest _sing;
        private readonly ISconTest _scon;
        private readonly ITranTest _tran;
        private readonly IAService _aService;

        public TestController(ISingTest sing, ISconTest scon, ITranTest tran, IAService aService)
        {
            _sing = sing;
            _scon = scon;
            _tran = tran;
            _aService = aService;
        }

        public ActionResult<IEnumerable<string>> SetTest()
        {
            _sing.Age = 18;
            _sing.Name = "小红";

            _tran.Age = 19;
            _tran.Name = "小明";

            _scon.Age = 20;
            _scon.Name = "小蓝";

            _aService.RedisTest();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
