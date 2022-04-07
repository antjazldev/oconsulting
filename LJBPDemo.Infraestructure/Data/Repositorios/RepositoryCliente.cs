using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Infraestructure.Data.Repositorios
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente 
    {
        private readonly SqlContext sqlContext;
        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
