using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Domain.Entities
{
    public class Movimiento
    {
        public int Id { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
