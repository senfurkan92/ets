using BLL.Data.Service;
using CORE.Data;
using CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Data.Manager
{
    public abstract class ManagerGeneric<TEntity, TDal> : IService<TEntity>
        where TEntity : class, IBaseEntity
        where TDal : class, IRepo<TEntity>
    {

        protected readonly TDal _dal;

        public ManagerGeneric(TDal dal)
        {
            _dal = dal;
        }

        public async Task<ReturnModel<bool>> Delete(int id)
        {
            var entityQuery = await _dal.Read(x => x.Id == id);
            return await _dal.Delete(entityQuery.Result);
        }

        public virtual Task<ReturnModel<TEntity>> Insert(TEntity entity)
        {
            return _dal.Insert(entity);
        }

        public Task<ReturnModel<TEntity>> Read(Expression<Func<TEntity, bool>> filter, params string[] tables)
        {
            return _dal.Read(filter, tables);
        }

        public Task<ReturnModel<IQueryable<TEntity>>> ReadAll(Expression<Func<TEntity, bool>> filter = null, bool asc = true, string orderBy = "Id", int skip = 0, int take = 10, params string[] tables)
        {
            return _dal.ReadAll(filter, asc, orderBy, skip, take, tables);
        }

        public virtual Task<ReturnModel<TEntity>> Update(TEntity entity)
        {
            return _dal.Update(entity);
        }
    }
}
