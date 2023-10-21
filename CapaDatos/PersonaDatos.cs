using CapaEntidades;
using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PersonaDatos
    {

        string archivo = "Persona.txt";
        public bool guardar(List<Persona> personas)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Persona Persona in personas)
                {
                    sw.WriteLine(Persona.IdPersona + ";" +
                    Persona.Nombre + ";" +
                    Persona.Apellido + ";" +
                    Persona.Cedula + ";" +
                    Persona.Correo + ";" +
                    Persona.Telefono + ";" +
                    Persona.Perfil + ";" +
                    Persona.IdHotel);
                }

                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception al guardar el archivo: " + e.Message);
            }
            return false;
        }

        public List<Persona> leer()
        {

            List<Persona> lista = new List<Persona>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Persona p = new Persona();
                    p.IdPersona = long.Parse(array[0]);
                    p.Nombre = array[1];
                    p.Apellido = array[2];
                    p.Cedula = array[3];
                    p.Correo = array[4];
                    p.Telefono = array[5];
                    p.Perfil = array[6];
                    p.IdHotel = long.Parse(array[7]);

                    // A la lista vacia le meto la persona
                    lista.Add(p);
                    //Paso a la otra linea
                    linea = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception al leer el archivo: " + e.Message);

            }
            return lista;
        }


    }

}

