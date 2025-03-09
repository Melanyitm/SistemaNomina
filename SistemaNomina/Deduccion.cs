using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class Deduccion
    {
        public string  Concepto { get; set; }
        public decimal Monto { get; set; }

        public Deduccion(string concepto, decimal monto) 
        { 
            Concepto = concepto;
            Monto = monto;
        }
    }
}
