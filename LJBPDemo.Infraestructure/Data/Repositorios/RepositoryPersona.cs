using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Infraestructure.Data.Repositorios
{
    public class RepositoryPersona : RepositoryBase<Persona>, IRepositoryPersona

    {
        private readonly SqlContext sqlContext;
        public RepositoryPersona(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
