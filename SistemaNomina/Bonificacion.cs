using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class Bonificacion
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        private const int horasExtra = 50000;
        private const int referido = 100000;

        public Bonificacion(string descripcion, decimal monto)
        {
            Descripcion = descripcion;
            Monto = monto;
        }

        public static decimal CalcularBonificacion(string tipo)
        {
            switch (tipo)
            {
                case "Horas Extra":
                    return horasExtra;
                case "Referido":
                    return referido;
                default:
                    return 0;
            }
        }

    }
}
