using Jeans.User.Core;
using System.Linq;

namespace Jeans.User.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// 单表操作(因为没有用延迟加载)
        /// </summary>
        /// <param name="id">标识符</param>
        /// <returns></returns>
        TEntity GetById(params object[] ids);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IQueryable<TEntity> Table { get; }

        IQueryable<TEntity> TableNoTracking { get; }
    }
}