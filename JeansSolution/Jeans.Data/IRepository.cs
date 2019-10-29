using Jeans.Core.Domins;
using System.Collections.Generic;
using System.Linq;

namespace Jeans.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }

        T GetById(object id);

        void Insert(T entity);
        void Insert(IEnumerable<T> entities);

        void Update(T entity);
        void Update(IEnumerable<T> entities);

        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
    }
}
