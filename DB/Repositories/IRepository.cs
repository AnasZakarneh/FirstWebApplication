using DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repositories
{
    public interface IRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        public IEnumerable<TEntity> GetAll();

        Task<TEntity> Create(TEntity entity);

        public TEntity FindById(TId id);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

        public void Update(TEntity t);

        public void Remove(TId id);
    }
}
