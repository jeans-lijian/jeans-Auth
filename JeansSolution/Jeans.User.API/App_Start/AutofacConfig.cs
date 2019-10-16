using Autofac;
using Autofac.Integration.WebApi;
using Jeans.User.Data;
using Jeans.User.Services.Account;
using System.Reflection;
using System.Web.Http;

namespace Jeans.User.API
{
    public static class AutofacConfig
    {
        public static void RegisterBundles()
        {
            var builder = new ContainerBuilder();

            Register(builder);

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void Register(ContainerBuilder builder)
        {
            //builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>));
            //builder.RegisterType<UserContext>().As<IDbContext>();
            //builder.RegisterType<UserService>().As<IUserService>();
        }
    }
}