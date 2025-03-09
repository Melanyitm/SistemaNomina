using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class Beneficio
    {
        public string Tipo { get; set; }
        public decimal Monto { get; set; }


        public Beneficio(string tipo, decimal monto)
        {
            Tipo = tipo;
            Monto = monto;
        }
    }
}
