﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpeSes3.Modelos
{
    internal class Persona
    {
        public Persona() { }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }
        public int CalcularEdad()
        {
            int edad = 0;
            try
            {
                edad = DateTime.Now.Year - FechaNac.Year;
            } catch (Exception ex) 
            {
            Console.WriteLine($"OCurrio un error: {ex.Message}");
            }
            return edad;
        }
        public string EvaluarEdad()
        {
            if (CalcularEdad() >= 18) return "Mayor de edad";
            return "Menor de edad";
        }
    }
}
