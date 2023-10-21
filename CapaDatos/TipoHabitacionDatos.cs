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
    public class TipoHabitacionDatos
    {
        string archivo = "TipoHabitacion.txt";
        public bool guardar(List<TipoHabitacion> TipoHabitaciones)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (TipoHabitacion tipoHabitacion in TipoHabitaciones)
                {
                    sw.WriteLine(tipoHabitacion.IdTipoHabitacion + ";" +
                    tipoHabitacion.IdHotel + ";" +
                    tipoHabitacion.Descripcion + ";" +
                    tipoHabitacion.Precio);
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

        public List<TipoHabitacion> leer()
        {

            List<TipoHabitacion> lista = new List<TipoHabitacion>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null && linea != "")
                {
                    string[] array = linea.Split(';');
                    TipoHabitacion p = new TipoHabitacion();
                    p.IdTipoHabitacion = long.Parse(array[0]);
                    p.IdHotel = long.Parse(array[1]);
                    p.Descripcion = array[2];
                    p.Precio = double.Parse(array[3]);

                    // A la lista vacia le meto el tipo de habitacion 
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
