using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Dukan.Core.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity Insert(TEntity entity);
        void Delete(TEntity entity);
    }
}
