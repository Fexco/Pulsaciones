using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace Pulsaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            PersonaService personaService = new PersonaService();
           
            Console.Write("Digite identificación: ");
            persona.Identificacion = Console.ReadLine();

            Console.Write("Digite nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.Write("Digite edad: ");
            persona.Edad = int.Parse(Console.ReadLine());

            Console.Write("Digite sexo: ");
            persona.Sexo = Console.ReadLine();

            personaService.CalcularPulsacion(persona);
            personaService.Guardar(persona);

            personaService.Consultar();


            Console.ReadKey();


        }
    }
}
