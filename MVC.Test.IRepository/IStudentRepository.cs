using MVC.Test.IRepository.Base;
using MVC.Test.Model.ttt_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Test.IRepository
{
    public interface IStudentRepository: IBaseRepository<Student>
    {
         void Haha();
    }
}
