using CORE.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Data
{
    public class Repo<TEntity, TContext> : IRepo<TEntity>
        where TEntity : class, IBaseEntity
        where TContext : DbContext
    {
        private readonly TContext _ctx;
        protected readonly DbSet<TEntity> _entities;

        public Repo(TContext ctx)
        {
            _ctx = ctx;
            _entities = _ctx.Set<TEntity>();
        }

        public async Task<ReturnModel<TEntity>> Insert(TEntity entity)
        {
            try
            {
                entity.InsertDate = DateTime.Now;
                var result = await _entities.AddAsync(entity);
                return new ReturnModel<TEntity>
                {
                    Result = result.Entity,
                    Success = await _ctx.SaveChangesAsync() > 0,
                };
            }
            catch (Exception exp)
            {
                return new ReturnModel<TEntity>
                {
                    Success = false,
                    Exception = exp
                };
            } 
        }

        public async Task<ReturnModel<TEntity>> Update(TEntity entity)
        {
            try
            {
                var result = _entities.Update(entity);
                return new ReturnModel<TEntity>
                {
                    Result = result.Entity,
                    Success = await _ctx.SaveChangesAsync() > 0,
                };
            }
            catch (Exception exp)
            {
                return new ReturnModel<TEntity>
                {
                    Success = false,
                    Exception = exp
                };
            }
        }

        public async Task<ReturnModel<bool>> Delete(TEntity entity)
        {
            try
            {
                var result = _entities.Remove(entity);
                var success = await _ctx.SaveChangesAsync() > 0;
                return new ReturnModel<bool>
                {
                    Result = success,
                    Success = success,
                };
            }
            catch (Exception exp)
            {
                return new ReturnModel<bool>
                {
                    Success = false,
                    Exception = exp
                };
            }
        }

        public async Task<ReturnModel<TEntity>> Read(Expression<Func<TEntity, bool>> filter, params string[] tables)
        {
            var extended = _entities as IQueryable<TEntity>;

            if (tables is not null && tables.Length > 0)
            {
                foreach (var table in tables) { 
                    extended = extended?.Include(table);
                }
            }

            var result = extended?.FirstOrDefault(filter);

            return new ReturnModel<TEntity>
            {
                Success = true,
                Result = result
            };
        }

        public async Task<ReturnModel<IQueryable<TEntity>>> ReadAll(Expression<Func<TEntity, bool>> filter = null, bool asc = true, string orderBy = "Id", int skip = 0, int take = 10, params string[] tables)
        {
            var extended = _entities as IQueryable<TEntity>;

            extended = filter is not null ? extended?.Where(filter) : extended;
            extended = CustomOrderBy(extended, asc, orderBy);
            extended = extended.Skip(skip);
            extended = extended.Take(take);

            if (tables is not null && tables.Length > 0)
            {
                foreach (var table in tables)
                {
                    extended = extended?.Include(table);
                }
            }

            return new ReturnModel<IQueryable<TEntity>>
            {
                Success = true,
                Result = extended
            };
        }

        private IQueryable<TEntity> CustomOrderBy(IQueryable<TEntity> source, bool asc, string propertyName = "Id")
        {
             PropertyInfo propertyInfo = typeof(TEntity).GetProperty(propertyName);

            var type = typeof(TEntity);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, propertyInfo);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var order = asc ? "OrderBy" : "OrderByDescending";
            var resultExpression = Expression.Call(typeof(Queryable), order, new Type[] { type, propertyInfo.PropertyType },
                                          source.Expression, Expression.Quote(orderByExpression));
            return source.Provider.CreateQuery<TEntity>(resultExpression);
        }

    }
}
