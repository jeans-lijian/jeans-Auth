using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Jeans.User.Core;

namespace Jeans.User.Data
{
    public interface IDbContext
    {
        int SaveChanges();

        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
    }
}