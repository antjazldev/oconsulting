using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Domain.Core.Interfaces.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente):base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}
