using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {
        private string  ruta = "Persona.txt";
        private List<Persona> Personas;

        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);

            escritor.WriteLine($"{persona.Identificacion};{persona.Nombre};" +
                $"{persona.Sexo};{persona.Edad};{persona.Pulsaciones};");
            escritor.Close();
            file.Close();
        }
        public List<Persona> Consultar()
        {
            Personas = new List<Persona>();
            string Linea = string.Empty;
            FileStream  SourceStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader Reader = new StreamReader(SourceStream);

            while((Linea = Reader.ReadLine())!= null)
            {
                Persona persona = new Persona();
                char delimiter = ';';
                string[] MatrizPersona = Linea.Split(delimiter);
                persona.Identificacion = MatrizPersona[0];
                persona.Nombre = MatrizPersona[1];
                persona.Sexo = MatrizPersona[2];
                persona.Edad = Convert.ToInt32(MatrizPersona[3]);
                persona.Pulsaciones = Convert.ToDecimal(MatrizPersona[4]);
                Personas.Add(persona);
            }
            
            Reader.Close();
            SourceStream.Close();
            return Personas; 
        }
    }


}
