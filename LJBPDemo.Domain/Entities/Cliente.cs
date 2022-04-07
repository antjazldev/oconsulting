using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LJBPDemo.Domain.Entities
{
    
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string Password { get; set; }
        public bool Estado { get; set; }
        public virtual ICollection<Cuenta> Cuentas { get; set; }
    }
}
