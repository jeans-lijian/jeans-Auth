using Jeans.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Jeans.Data
{
    public class ShopOrderContext : DbContext, IDbContext
    {
        public ShopOrderContext(DbContextOptions<ShopOrderContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureMappingExtesions.Mapping(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public virtual new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public IQueryable<TQuery> QueryFromSql<TQuery>(string sql, params object[] parameters) where TQuery : class
        {
            return Query<TQuery>().FromSql(sql, parameters);
        }

        public int ExecuteSqlCommand(RawSqlString sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
        {
            var previousTimeout = Database.GetCommandTimeout();
            Database.SetCommandTimeout(timeout);

            var result = 0;
            if (!doNotEnsureTransaction)
            {
                using (var transaction = Database.BeginTransaction())
                {
                    result = Database.ExecuteSqlCommand(sql, parameters);
                    transaction.Commit();
                }
            }
            else
            {
                result = Database.ExecuteSqlCommand(sql, parameters);
            }

            Database.SetCommandTimeout(previousTimeout);
            return result;
        }

    }
}
