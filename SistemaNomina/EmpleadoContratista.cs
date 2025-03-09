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

        public EmpleadoContratista(int id, string nombre, string apellido, string docuemnto, string cargo, decimal tarifaPorHora, int horasTrabahadas, DateTime fechaPago, string observaciones)
            : base(id, nombre, apellido, docuemnto, cargo, tarifaPorHora * horasTrabahadas, fechaPago, observaciones)
        {
            TarifaPorHora = tarifaPorHora;
            HorasTrabajadas = horasTrabahadas;
        }

        public override decimal CalcularSalario()
        {
            return TarifaPorHora * HorasTrabajadas;
        }

    }
}
