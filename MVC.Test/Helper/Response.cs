using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test.Helper
{
    public class Response
    {
        public int code { get; set; }

        public string msg { get; set; }

        public bool isSuccess { get; set; }
    }
}
