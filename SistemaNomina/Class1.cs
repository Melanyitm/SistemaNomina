using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public abstract class Empleado
    { public int id { get; set; }
        public int Id { get; }
        public string Nombre { get; set; }
      public string Apellido { get; set; }
      public string Documento { get; set; }
      public string Cargo { get; set; }
      public decimal SalarioBase { get; set; }
      public decimal DeduccionSalud { get; set; }
      public decimal DeduccionPension { get; set; }
      public DateTime FechaPago { get; set; }
      public string Observaciones { get; set; }


        public Empleado(int id, string nombre, string apellido, string documento, string cargo, decimal salarioBase, DateTime fechaPago, string observaciones)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Cargo = cargo;
            SalarioBase = salarioBase;
            DeduccionSalud = salarioBase * 0.04m;
            DeduccionPension = salarioBase * 0.04m;
            FechaPago = fechaPago;
            Observaciones = observaciones;

        }

        public abstract decimal CalcularSalario();

    }

    
    
}
