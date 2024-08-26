using MpeSes3.Modelos;
using System.Runtime.InteropServices;

namespace MpeSes3
{//Calcular la edad de una persona y determinar si es mayor de edad
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string nombre;
            DateTime fechaNac;
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine ("Fecha de nacimiento: ");
                fechaNac=DateTime.Parse(Console.ReadLine());
            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;
            Console.WriteLine(persona.EvaluarEdad());

        }
    }
}