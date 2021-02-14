using Api.Basica.Domain.Interfaces.Repositories;
using Api.Basica.Domain.Interfaces.Repositories.Base;
using Api.Basica.Infra.Persistence;
using Api.Basica.Infra.Persistence.Repositories;
using Api.Basica.Infra.Persistence.Repositories.Base;
using Api.Basica.Infra.Transactions;
using Api.Basica.Interfaces.Repositories;
using Api.Basica.Interfaces.Services;
using Api.Basica.Services;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;

namespace Api.Basica.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DbContext, BNCContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceUsuario, ServiceUsuario>(new HierarchicalLifetimeManager());
            container.RegisterType<IPerfilDeUsuarioService, ServicePerfilDeUsuario>(new HierarchicalLifetimeManager());

            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryPerfilDeUsuario, RepositoryPerfilDeUsuario>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryUsuario, RepositoryUsuario>(new HierarchicalLifetimeManager());
        }
    }
}
