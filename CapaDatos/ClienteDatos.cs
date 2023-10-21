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
    public class ClienteDatos
    {
        string archivo = "Cliente.txt";
        public bool guardar(List<Cliente> clientes)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Cliente cliente in clientes)
                {
                    sw.WriteLine(cliente.IdPersona + ";" +
                    cliente.Nombre + ";" +
                    cliente.Apellido + ";" +
                    cliente.Cedula + ";" +
                    cliente.Correo + ";" +
                    cliente.Telefono + ";" +
                    cliente.Perfil + ";" +
                    cliente.IdHotel);
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

        public List<Cliente> leer()
        {

            List<Cliente> lista = new List<Cliente>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Cliente p = new Cliente();
                    p.IdPersona = long.Parse(array[0]);
                    p.Nombre = array[1];
                    p.Apellido = array[2];
                    p.Cedula = array[3];
                    p.Correo = array[4];
                    p.Telefono = array[5];
                    p.Perfil = array[6];
                    p.IdHotel = long.Parse(array[7]);

                    // A la lista vacia le meto el cliente
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
