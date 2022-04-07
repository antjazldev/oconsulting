using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Domain.Entities
{
    public class Cuenta
    {
        public int Id { get; set; }
        public long NumeroCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public decimal SaldoInicial { get; set; }
        public bool Estado { get; set; }
        public decimal LimiteDiario { get; set; }
        public decimal SaldoLimiteDiario { get; set; }
        public ICollection<Movimiento> Movimientos { get; set; }
        public Cliente Cliente { get; set; }

    }
}
