using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class Beneficio
    {
        public string Concepto { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }


        public Beneficio(string concepto, string tipo, decimal monto)
        {
            Tipo = tipo;
            Concepto = concepto;
            Monto = monto;
        }
    }
}
