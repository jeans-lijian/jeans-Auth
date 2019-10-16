using Jeans.User.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeans.User.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IDbContext _dbContext;
        private DbSet<TEntity> _entities;
        public EfRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity GetById(params object[] ids)
        {
            return Entities.Find(ids);
        }

        public void Insert(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                Entities.Add(entity);
                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException dbExc)
            {
                throw new Exception(dbExc.Message);
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException dbExc)
            {
                throw new Exception(dbExc.Message);
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                Entities.Remove(entity);
                _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException dbExc)
            {
                throw new Exception(dbExc.Message);
            }
        }

        public IQueryable<TEntity> Table => Entities;

        public IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();

        protected DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _dbContext.Set<TEntity>();
                }

                return _entities;
            }
        }
    }
}