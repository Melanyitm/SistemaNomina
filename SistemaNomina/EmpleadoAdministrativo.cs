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
        public decimal SalarioBase { get; set; }
        private const decimal DeduccionSalud = 0.04m;
        private const decimal DeduccionPension = 0.04m;
        public EmpleadoAdministrativo(int id, string nombre, string apellido, DateTime fechaIngreso, DateTime fechaPago, decimal salarioBase)
        : base(id, nombre, apellido, fechaIngreso, fechaPago, salarioBase * (DeduccionSalud + DeduccionPension))
        {
            SalarioBase = salarioBase;
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase-Deducciones;
        }


    }
}
