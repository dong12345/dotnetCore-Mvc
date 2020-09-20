using MVC.Test.IService.test;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.Service.test
{
    public class AService : IAService
    {
        private readonly ISingTest _sing;
        private readonly ITranTest _tran;
        private readonly ISconTest _scon;

        public AService(ISingTest sing, ITranTest tran, ISconTest scon)
        {
            _sing = sing;
            _tran = tran;
            _scon = scon;
        }
        public void RedisTest()
        {
        }
    }
}
