using DB.Data;
using DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repositories
{
    public abstract class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        protected readonly ApplicationDbContext _context;
        protected abstract IQueryable<TEntity> RetrieveQuery { get; }

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            var result = await _context.Set<TEntity>().AddAsync(entity);
            _context.SaveChanges();

            return result.Entity;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

        public TEntity FindById(TId id)
        {
            return _context.Set<TEntity>().FirstOrDefault(e => e.Id.Equals(id));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public void Remove(TId id)
        {
            var entity = FindById(id);
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
