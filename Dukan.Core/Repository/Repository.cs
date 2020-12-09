using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Dukan.Core.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal readonly ProductsEntities Context;
        internal DbSet<TEntity> DbSet;

        public Repository(ProductsEntities context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }


        public TEntity Insert(TEntity entity)
        {
            DbSet.Add(entity);
            Complete();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Complete()
        {
            Context.SaveChanges();
        }
    }
}
