using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Domain.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
