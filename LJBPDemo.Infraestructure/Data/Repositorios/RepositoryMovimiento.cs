using LJBPDemo.Domain.Core.Interfaces.Repository;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Infraestructure.Data.Repositorios
{
    public class RepositoryMovimiento : RepositoryBase<Movimiento>, IRepositoryMovimiento
    {
        private readonly SqlContext sqlContext;
        public RepositoryMovimiento(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
