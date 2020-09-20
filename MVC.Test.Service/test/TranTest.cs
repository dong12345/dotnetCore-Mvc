using MVC.Test.IService.test;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.Service.test
{
    public class TranTest : ITranTest
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
