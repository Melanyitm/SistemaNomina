using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class EmpleadoAdministrativo : Empleado
    {
        public EmpleadoAdministrativo(int id, string nombre, string apellido, string documento, string cargo, decimal salarioBase, DateTime fechaPago, string observaciones)
        : base(id, nombre, apellido, documento, cargo, salarioBase,fechaPago,observaciones)
        { }

        public override decimal CalcularSalario()
        {
            return SalarioBase - (DeduccionSalud + DeduccionPension);
        }


    }
}
