﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina
{
    public abstract class Empleado
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }
        public DateTime FechaPago { get; set; }
        public string Observaciones { get; set; }



        public Empleado(int id, string nombre, string apellido, string documento, string cargo, decimal salarioBase, DateTime fechaPago, string observaciones)
        {
            Id = id;
            Nombre = nombre; // Corregir el error tipográfico
            Apellido = apellido;
            Documento = documento;
            Cargo = cargo;
            SalarioBase = salarioBase;
            FechaPago = fechaPago;
            Observaciones = observaciones;
        }

        public abstract decimal CalcularSalario();


    }

    
    
}
