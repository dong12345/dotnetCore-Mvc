using Microsoft.EntityFrameworkCore;
using MVC.Test.IRepository.Base;
using MVC.Test.Repository.EF;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Test.Repository.Base
{
    public  class EFBaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly DbSet<TEntity> _dbSet;
        public EFDBContext _context { get; } = null;
        public EFBaseRepository(EFDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public Task<int> Add(TEntity model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Add(List<TEntity> listEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(TEntity model)
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

        public Task<List<TEntity>> Query()
        {
             return _dbSet.ToListAsync();
        }

        public Task<List<TEntity>> Query(string strWhere)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Expression<Func<TEntity, object>> orderByExpression, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(string strWhere, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, int intTop, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(string strWhere, int intTop, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> QueryById(object objId)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> QueryById(object objId, bool blnUseCache = false)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QueryByIDs(object[] lstIds)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResult>> QueryMuch<T, T2, T3, TResult>(Expression<Func<T, T2, T3, object[]>> joinExpression, Expression<Func<T, T2, T3, TResult>> selectExpression, Expression<Func<T, T2, T3, bool>> whereLambda = null) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QuerySql(string strSql, SugarParameter[] parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> QueryTable(string strSql, SugarParameter[] parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(TEntity model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(TEntity entity, string strWhere)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(object operateAnonymousObjects)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(TEntity entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "")
        {
            throw new NotImplementedException();
        }
    }
}
