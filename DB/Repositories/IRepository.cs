using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repositories
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();

        public Task<T> Create(T t);

        public T GetById(int id);

        public void Update(T t);

        public void Delete(int id);
    }
}
