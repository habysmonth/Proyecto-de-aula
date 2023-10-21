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
    public class HotelDatos
    {
        string archivo = "Hotel.txt";
        public bool guardar(List<Hotel> Hoteles)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Hotel Hotel in Hoteles)
                {
                    sw.WriteLine(Hotel.IdHotel + ";" +
                    Hotel.Nombre + ";" +
                    Hotel.Direccion + ";" +
                    Hotel.Correo);
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

        public List<Hotel> leer()
        {

            List<Hotel> lista = new List<Hotel>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Hotel p = new Hotel();
                    p.IdHotel = long.Parse(array[0]);
                    p.Nombre = array[1];
                    p.Direccion = array[2];
                    p.Correo = array[3];

                    // A la lista vacia le meto el hotel
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

