using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public class NominaGeneral
    {
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();
        public List<Beneficio> Beneficios { get; set; } = new List<Beneficio>();
        public List<Deduccion> Deducciones { get; set; } = new List<Deduccion>();

        public void CalcularNomina()
        {
            decimal totalSalari = Empleados.Sum(e => e.CalcularSalario());
            decimal beneficios = Beneficios.Sum(b => b.Monto);
            decimal deducciones = Deducciones.Sum(d => d.Monto);

            Console.WriteLine($"Total salarios: {totalSalari:C}");
            Console.WriteLine($"Total beneficios: {Beneficios:C}");
            Console.WriteLine($"Total deducciones: {Deducciones:C}");

        }
        public void MostrarNomina()
        {
            Console.WriteLine("\n--- Nómina de Empleados ---");
            foreach (var empleado in Empleados)
            {
                Console.WriteLine($"Empleado: {empleado.Nombre} {empleado.Apellido} - Salario: {empleado.CalcularSalario():C} ");
            }
        }
    }
}

