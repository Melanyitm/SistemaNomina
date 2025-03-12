using System;
using SistemaNomina;

class Program
{
    static void Main(string[] args)
    {
        NominaGeneral nomina = new NominaGeneral();

        // Crear empleados
        EmpleadoFijo empleadoFijo = new EmpleadoFijo(1, "Juan", "Perez", "12345678", "Gerente", 3000, 500, DateTime.Now, "Ninguna");
        EmpleadoContratista empleadoContratista = new EmpleadoContratista(2, "Maria", "Gomez", "87654321", "Desarrollador", 50, 160, DateTime.Now, "Ninguna");

        nomina.AgregarEmpleado(empleadoFijo);
        nomina.AgregarEmpleado(empleadoContratista);

        // Crear beneficios y deducciones
        Beneficio beneficio = new Beneficio("Bonificación Anual", "Monetario", 1000);
        Deduccion deduccion = new Deduccion("Impuesto", 200);

        nomina.AgregarBeneficio(beneficio);
        nomina.AgregarDeduccion(deduccion);

        // Mostrar nómina inicial
        Console.WriteLine("--- Nómina inicial ---");
        nomina.MostrarNomina();
        nomina.CalcularNomina();

        // Actualizar empleado
        EmpleadoFijo empleadoFijoActualizado = new EmpleadoFijo(1, "Juan", "Perez", "12345678", "Gerente", 3500, 500, DateTime.Now, "Ninguna");
        nomina.ActualizarEmpleado(1, empleadoFijoActualizado);

        // Eliminar empleado
        Console.WriteLine("\nEliminando empleado con ID 2...");
        nomina.EliminarEmpleado(2);

        // Mostrar nómina actualizada
        Console.WriteLine("\n--- Nómina actualizada ---");
        nomina.MostrarNomina();
        nomina.CalcularNomina();
    }
}