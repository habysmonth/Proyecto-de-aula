using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReservacionDatos
    {
        string archivo = "Reservacion.txt";
        public bool guardar(List<Reservacion> reservaciones)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Reservacion reservacion in reservaciones)
                {
                    sw.WriteLine(reservacion.NumeroReserva + ";" +
                    reservacion.IdCliente + ";" +
                    reservacion.IdHabitacion + ";" +
                    reservacion.NumeroAdultos + ";" +
                    reservacion.NumeroNiños + ";" +
                    reservacion.FechaInicio + ";" +
                    reservacion.FechaFin + ";" +
                    reservacion.Estado);
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

        public List<Reservacion> leer()
        {

            List<Reservacion> lista = new List<Reservacion>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Reservacion p = new Reservacion();
                   
                    p.NumeroReserva = long.Parse(array[0]);
                    p.IdCliente = long.Parse(array[1]);
                    p.IdHabitacion = long.Parse(array[2]);
                    p.NumeroAdultos = int.Parse(array[3]);
                    p.NumeroNiños = int.Parse(array[4]);
                    p.FechaInicio = DateTime.Parse(array[5]);
                    p.FechaFin = DateTime.Parse(array[6]);
                    p.Estado = array[7];

                    // A la lista vacia le meto la reservacion
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
