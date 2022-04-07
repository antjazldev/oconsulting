using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Domain.Core.Interfaces.Services
{
    public class ServiceMovimiento : ServiceBase<Movimiento>, IServiceMovimiento
    {
        private readonly IRepositoryMovimiento repositoryMovimiento;
        public ServiceMovimiento(IRepositoryMovimiento repositoryMovimiento) : base(repositoryMovimiento)
        {
            this.repositoryMovimiento = repositoryMovimiento;
        }
    }
}
