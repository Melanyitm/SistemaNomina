using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public abstract class Empleado : ICalcular1
    { public int Id { get; set; }
      public string Nombre { get; set; }
      public string Apellido { get; set; }
      public DateTime FechaInicio { get; set; }
      public DateTime FechaPago { get; set; }
      public decimal Deducciones { get; set; }


        public Empleado(int id, string nombre, string apellido, DateTime fechaInicio, DateTime fechaPago, decimal deducciones)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaInicio = fechaInicio;
            FechaPago = fechaPago;
            Deducciones = deducciones;

        }

        public abstract decimal CalcularSalario();

    }

    
    
}
