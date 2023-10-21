using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDatos
    {
        string archivo = "Producto.txt";
        public bool guardar(List<Producto> productos)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Producto producto in productos)
                {
                    sw.WriteLine(producto.IdProducto + ";" +
                    producto.IdHotel + ";" +
                    producto.Codigo + ";" +
                    producto.Nombre + ";" +
                    producto.Descripcion + ";" +
                    producto.Cantidad + ";" +
                    producto.Precio);
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

        public List<Producto> leer()
        {

            List<Producto> lista = new List<Producto>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Producto p = new Producto();
                    p.IdProducto = long.Parse(array[0]);
                    p.IdHotel = long.Parse(array[1]);
                    p.Codigo = array[2];
                    p.Nombre = array[3];
                    p.Descripcion = array[4];
                    p.Cantidad = int.Parse(array[5]);
                    p.Precio = double.Parse(array[6]);

                    // A la lista vacia le meto la factura
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

