using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class EmpleadoFijo : Empleado
    {
        public decimal Bonificacion { get; set; }

        public EmpleadoFijo(int id, string nombre, string apellido, string documento,string cargo, decimal salarioBase, decimal bonificacion, DateTime fechaPago, string observaciones)
            : base(id,nombre,apellido,documento,cargo,salarioBase,fechaPago,observaciones)
        {
            Bonificacion = bonificacion;
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase + Bonificacion - (DeduccionSalud + DeduccionPension);
        }
    }
}
