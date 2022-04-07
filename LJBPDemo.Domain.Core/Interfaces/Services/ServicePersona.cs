using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Domain.Core.Interfaces.Services
{
    public class ServicePersona : ServiceBase<Persona>, IServicePersona
    {
        private readonly IRepositoryPersona repositoryPersona;
        public ServicePersona(IRepositoryPersona repositoryPersona) : base(repositoryPersona)
        {
            this.repositoryPersona = repositoryPersona;
        }
    }
}
