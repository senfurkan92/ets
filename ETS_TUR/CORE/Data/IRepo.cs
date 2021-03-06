using CORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Data
{
    public interface IRepo <TEntity> where TEntity : class, IBaseEntity
    {
        Task<ReturnModel<TEntity>> Insert(TEntity entity);

        Task<ReturnModel<TEntity>> Update(TEntity entity);

        Task<ReturnModel<bool>> Delete(TEntity entity);

        Task<ReturnModel<TEntity>> Read(Expression<Func<TEntity, bool>> filter, params string[] tables);

        Task<ReturnModel<IQueryable<TEntity>>> ReadAll(Expression<Func<TEntity, bool>> filter = null, bool asc = true, string orderBy = "Id", int skip = 0, int take = 10, params string[] tables);
    }
}
