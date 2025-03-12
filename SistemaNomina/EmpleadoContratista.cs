using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class EmpleadoContratista : Empleado
    {
        public decimal TarifaPorHora { get; set; }
        public int HorasTrabajadas { get; set; }

        public EmpleadoContratista(int id, string nombre, string apellido, DateTime fechaIngreso, DateTime fechaPago, int horasTrabajadas, decimal tarifaPorHora)
        : base(id, nombre, apellido, fechaIngreso, fechaPago, 0)
        {
            TarifaPorHora = tarifaPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularSalario()
        {
            return TarifaPorHora * HorasTrabajadas;
        }

    }
}
