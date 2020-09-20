﻿using MVC.Test.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Test.IService
{
    public interface IExhibitorDBService:IBaseService<ExhibitorDB>
    {
        string GetHAHA();
    }
}
