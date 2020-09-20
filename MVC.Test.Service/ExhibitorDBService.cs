using MVC.Test.IService;
using MVC.Test.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Test.Service
{
    public class ExhibitorDBService : BaseService<ExhibitorDB>, IExhibitorDBService
    {
        public string GetHAHA()
        {
            return "haha";
        }
    }
}
