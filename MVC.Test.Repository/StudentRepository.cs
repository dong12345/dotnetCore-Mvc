using Microsoft.EntityFrameworkCore;
using MVC.Test.IRepository;
using MVC.Test.IRepository.Base;
using MVC.Test.Model.ttt_Entity;
using MVC.Test.Repository.EF;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Test.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IBaseRepository<Student> _baseRepository;
        private readonly EFDBContext _context;

        public StudentRepository(IBaseRepository<Student> baseRepository, EFDBContext context)
        {
            _baseRepository = baseRepository;
            _context = context;
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

        public void Haha()
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.ttt_Entity.Student>> Query()
        {
            return _baseRepository.Query();
            //var list = _context.Student.ToListAsync();
            //return list;
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
