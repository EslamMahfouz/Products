//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Threading.Tasks;

//namespace Center.Business.Repository
//{
//    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
//    {
//        private readonly CenterDbContext context;
//        public Repository(CenterDbContext context)
//        {
//            this.context = context;
//        }

//        public async Task<TEntity> Get(int id)
//        {
//            return await context.Set<TEntity>().FindAsync(id);
//        }
//        public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate = null)
//        {
//            return predicate != null ? await context.Set<TEntity>().Where(predicate).ToListAsync() : await context.Set<TEntity>().ToListAsync();
//        }

//        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
//        {
//            return context.Set<TEntity>().Where(predicate);
//        }

//        public async Task Add(TEntity entity)
//        {
//            await context.Set<TEntity>().AddAsync(entity);
//        }
//        public async Task AddRange(IEnumerable<TEntity> entities)
//        {
//            await context.Set<TEntity>().AddRangeAsync(entities);
//        }

//        public void Remove(TEntity entity)
//        {
//            context.Set<TEntity>().Remove(entity);
//        }
//        public void RemoveRange(IEnumerable<TEntity> entities)
//        {
//            context.Set<TEntity>().RemoveRange(entities);
//        }

//    }
//}
