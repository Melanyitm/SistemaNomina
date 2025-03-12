using SistemaNomina;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Seleccione el tipo de empleado:");
        Console.WriteLine("1. Fijo");
        Console.WriteLine("2. Contratista");
        Console.WriteLine("3. Administrativo");
        int tipoEmpleado = int.Parse(Console.ReadLine());

        Empleado empleado = tipoEmpleado switch
        {
            1 => new EmpleadoFijo(1, "Juan", "Pérez", DateTime.Now, DateTime.Now.AddMonths(1), 3000000),
            2 => new EmpleadoContratista(2, "Ana", "López", DateTime.Now, DateTime.Now.AddMonths(1), 160, 50000),
            3 => new EmpleadoAdministrativo(3, "Carlos", "Gómez", DateTime.Now, DateTime.Now.AddMonths(1), 2500000),
            _ => null
        };

        if (empleado == null)
        {
            Console.WriteLine("Selección inválida.");
            return;
        }

        if (tipoEmpleado == 1 || tipoEmpleado == 3)
        {
            Console.WriteLine("¿Desea agregar una bonificación? (Sí/No)");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si")
            {
                Console.WriteLine("Seleccione el tipo de bonificación:");
                Console.WriteLine("1. Horas Extra");
                Console.WriteLine("2. Referidos");
                int tipoBonificacion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad:");
                int cantidad = int.Parse(Console.ReadLine());

                decimal montoBonificacion = Bonificacion.CalcularBonificacion(tipoBonificacion == 1 ? "Horas Extra" : "Referido") * cantidad;
                Console.WriteLine($"Salario Final con Bonificación: {(empleado.CalcularSalario() + montoBonificacion):C}");
            }
            else
            {
                Console.WriteLine($"Salario Final: {empleado.CalcularSalario():C}");
            }
        }
        else
        {
            Console.WriteLine($"Salario Final: {empleado.CalcularSalario():C}");
        }
    }
}
