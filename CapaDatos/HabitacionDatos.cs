using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class HabitacionDatos
    {
        string archivo = "Habitacion.txt";
        public bool guardar(List<Habitacion> Habitaciones)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Habitacion Habitacion in Habitaciones)
                {
                    sw.WriteLine(Habitacion.IdHabitacion + ";" +
                    Habitacion.IdHotel + ";" +
                    Habitacion.IdTipoHabitacion + ";" +
                    Habitacion.NumeroHabitacion + ";" +
                    Habitacion.Descripcion + ";" +
                    Habitacion.Estado);
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

        public List<Habitacion> leer()
        {

            List<Habitacion> lista = new List<Habitacion>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Habitacion p = new Habitacion();
                    p.IdHabitacion = long.Parse(array[0]);
                    p.IdHotel = long.Parse(array[1]);
                    p.IdTipoHabitacion = long.Parse(array[2]);
                    p.NumeroHabitacion = int.Parse(array[3]);
                    p.Descripcion = array[4];
                    p.Estado = array[5];

                    // A la lista vacia le meto la habitacion
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

