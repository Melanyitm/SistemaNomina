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
            decimal totalSalarios = Empleados.Sum(e => e.CalcularSalario());
            decimal totalBeneficios = Beneficios.Sum(b => b.Monto);
            decimal totalDeducciones = Deducciones.Sum(d => d.Monto);

            Console.WriteLine($"Total salarios: {totalSalarios:C}");
            Console.WriteLine($"Total beneficios: {totalBeneficios:C}");
            Console.WriteLine($"Total deducciones: {totalDeducciones:C}");
        }

        public void MostrarNomina()
        {
            Console.WriteLine("\n--- Nómina de Empleados ---");
            foreach (var empleado in Empleados)
            {
                Console.WriteLine($"Empleado: {empleado.Nombre} {empleado.Apellido} - Salario: {empleado.CalcularSalario():C} ");
            }
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void AgregarBeneficio(Beneficio beneficio)
        {
            Beneficios.Add(beneficio);
        }

        public void AgregarDeduccion(Deduccion deduccion)
        {
            Deducciones.Add(deduccion);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return Empleados;
        }

        public List<Beneficio> ObtenerBeneficios()
        {
            return Beneficios;
        }

        public List<Deduccion> ObtenerDeducciones()
        {
            return Deducciones;
        }

        public void ActualizarEmpleado(int id, Empleado empleadoActualizado)
        {
            var empleado = Empleados.FirstOrDefault(e => e.Id == id);
            if (empleado != null)
            {
                empleado.Nombre = empleadoActualizado.Nombre;
                empleado.Apellido = empleadoActualizado.Apellido;
                empleado.Documento = empleadoActualizado.Documento;
                empleado.Cargo = empleadoActualizado.Cargo;
                empleado.SalarioBase = empleadoActualizado.SalarioBase;
                empleado.FechaPago = empleadoActualizado.FechaPago;
                empleado.Observaciones = empleadoActualizado.Observaciones;
            }
        }

        public void ActualizarBeneficio(string concepto, Beneficio beneficioActualizado)
        {
            var beneficio = Beneficios.FirstOrDefault(b => b.Concepto == concepto);
            if (beneficio != null)
            {
                beneficio.Concepto = beneficioActualizado.Concepto;
                beneficio.Monto = beneficioActualizado.Monto;
            }
        }

        public void ActualizarDeduccion(string concepto, Deduccion deduccionActualizada)
        {
            var deduccion = Deducciones.FirstOrDefault(d => d.Concepto == concepto);
            if (deduccion != null)
            {
                deduccion.Concepto = deduccionActualizada.Concepto;
                deduccion.Monto = deduccionActualizada.Monto;
            }
        }
        public void EliminarEmpleado(int id)
        {
            var empleado = Empleados.FirstOrDefault(e => e.Id == id);
            if (empleado != null)
            {
                Empleados.Remove(empleado);
            }
        }

        public void EliminarBeneficio(string concepto)
        {
            var beneficio = Beneficios.FirstOrDefault(b => b.Concepto == concepto);
            if (beneficio != null)
            {
                Beneficios.Remove(beneficio);
            }
        }

        public void EliminarDeduccion(string concepto)
        {
            var deduccion = Deducciones.FirstOrDefault(d => d.Concepto == concepto);
            if (deduccion != null)
            {
                Deducciones.Remove(deduccion);
            }
        }
    }
}

