using MVC.Test.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.Service
{
    public class AdvertisementServices : IAdvertisementServices
    {
        public int Test()
        {
            return 1;
        }
    }
}
