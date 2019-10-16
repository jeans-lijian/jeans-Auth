using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;
using Jeans.User.Data.Mapping.Account;
using Jeans.User.Core;

namespace Jeans.User.Data
{
    public class UserContext : DbContext, IDbContext
    {
        public UserContext() : base("name=UserConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("QMS");
            //var typesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.BaseType != null && q.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            //foreach (var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    modelBuilder.Configurations.Add(configurationInstance);
            //}

            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
    }
}