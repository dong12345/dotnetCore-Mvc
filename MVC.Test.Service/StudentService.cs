using MVC.Test.IRepository;
using MVC.Test.IService;
using MVC.Test.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Test.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Task<int> Add(Model.ttt_Entity.Student model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Add(List<Model.ttt_Entity.Student> listEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Model.ttt_Entity.Student model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIds(object[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query()
        {
            return _studentRepository.Query();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(string strWhere)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(Expression<Func<Model.ttt_Entity.Student, bool>> whereExpression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(Expression<Func<Model.ttt_Entity.Student, bool>> whereExpression, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(Expression<Func<Model.ttt_Entity.Student, bool>> whereExpression, Expression<Func<Model.ttt_Entity.Student, object>> orderByExpression, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(string strWhere, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(Expression<Func<Model.ttt_Entity.Student, bool>> whereExpression, int intTop, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(string strWhere, int intTop, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(Expression<Func<Model.ttt_Entity.Student, bool>> whereExpression, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<Model.ttt_Entity.Student> QueryById(object objId)
        {
            throw new NotImplementedException();
        }

        public Task<Model.ttt_Entity.Student> QueryById(object objId, bool blnUseCache = false)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> QueryByIDs(object[] lstIds)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResult>> QueryMuch<T, T2, T3, TResult>(Expression<Func<T, T2, T3, object[]>> joinExpression, Expression<Func<T, T2, T3, TResult>> selectExpression, Expression<Func<T, T2, T3, bool>> whereLambda = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public Task<PageModel<Model.ttt_Entity.Student>> QueryPage(Expression<Func<Model.ttt_Entity.Student, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> QuerySql(string strSql, SugarParameter[] parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> QueryTable(string strSql, SugarParameter[] parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Model.ttt_Entity.Student model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Model.ttt_Entity.Student entity, string strWhere)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(object operateAnonymousObjects)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Model.ttt_Entity.Student entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "")
        {
            throw new NotImplementedException();
        }
    }
}
