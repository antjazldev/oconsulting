using Autofac;
using LJBPDemo.Application;
using LJBPDemo.Application.Interfaces;
using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Core.Interfaces.Services;
using LJBPDemo.Infraestructure.Data.Repositorios;

namespace LJBPDemo.Infraestructure.Crosscutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IoC
           builder.RegisterType<ApplicationServiceCuenta>().As<IApplicationServiceCuenta>();
           builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
           builder.RegisterType<ApplicationServicePersona>().As<IApplicationServicePersona>();
            builder.RegisterType<ApplicationServiceMovimiento>().As<IApplicationServiceMovimiento>();

            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
           builder.RegisterType<ServicePersona>().As<IServicePersona>();
           builder.RegisterType<ServiceCuenta>().As<IServiceCuenta>();
            builder.RegisterType<ServiceMovimiento>().As<IServiceMovimiento>();

           builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
           builder.RegisterType<RepositoryPersona>().As<IRepositoryPersona>();
           builder.RegisterType<RepositoryCuenta>().As<IRepositoryCuenta>();
           builder.RegisterType<RepositoryMovimiento>().As<IRepositoryMovimiento>();




            #endregion
        }
    }
}
