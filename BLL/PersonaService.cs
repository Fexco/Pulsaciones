using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository;
        public void CalcularPulsacion(Persona persona)
        {
            if (persona.Sexo.ToUpper().Equals("F"))
            {
                persona.Pulsaciones = (220 - persona.Edad) / 10;
            }
            else if (persona.Sexo.ToUpper().Equals("M"))
            {
                persona.Pulsaciones = (210 - persona.Edad) / 10;
            }
            else
            {
                persona.Pulsaciones = 0;
            }
        }
        public void Guardar(Persona persona)
        {
            personaRepository.Guardar(persona);
        }

        public void Consultar()
        {
            personaRepository.Consultar();
        }
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
    }
}
