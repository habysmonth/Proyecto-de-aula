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
    public class UsuarioDatos
    {
        string archivo = "Usuario.txt";
        public bool guardar(List<Usuario> usuarios)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Usuario usuario in usuarios)
                {
                    sw.WriteLine(usuario.IdPersona + ";" +
                    usuario.Nombre + ";" +
                    usuario.Apellido + ";" +
                    usuario.Cedula + ";" +
                    usuario.Correo + ";" +
                    usuario.Telefono + ";" +
                    usuario.Perfil + ";" +
                    usuario.IdHotel + ";" +
                    usuario.username + ";" +
                    usuario.password);
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

        public List<Usuario> leer()
        {

            List<Usuario> lista = new List<Usuario>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Usuario p = new Usuario();
                    p.IdPersona = long.Parse(array[0]);
                    p.Nombre = array[1];
                    p.Apellido = array[2];
                    p.Cedula = array[3];
                    p.Correo = array[4];
                    p.Telefono = array[5];
                    p.Perfil = array[6];
                    p.IdHotel = long.Parse(array[7]);
                    p.username = array[8];
                    p.password = array[9];

                    // A la lista vacia le meto el usuario
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
