using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;

namespace LJBPDemo.Domain.Core.Interfaces.Services
{
    public class ServiceCuenta : ServiceBase<Cuenta>, IServiceCuenta
    {
        private readonly IRepositoryCuenta repositoryCuenta;

        public ServiceCuenta(IRepositoryCuenta repositoryCuenta) : base(repositoryCuenta)
        {
            this.repositoryCuenta = repositoryCuenta;
        }
    }
}