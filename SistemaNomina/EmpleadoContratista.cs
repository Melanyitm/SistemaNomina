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

        public EmpleadoContratista(int id, string nombre, string apellido, string documento, string cargo, decimal tarifaPorHora, int horasTrabajadas, DateTime fechaPago, string observaciones)
            : base(id, nombre, apellido, documento, cargo, tarifaPorHora * horasTrabajadas, fechaPago, observaciones)
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
