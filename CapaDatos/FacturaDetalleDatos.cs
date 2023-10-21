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
    public class FacturaDetalleDatos
    {

        string archivo = "FacturaDetalle.txt";
        public bool guardar(List<FacturaDetalle> factura_detalles)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (FacturaDetalle FacturaDetalle in factura_detalles)
                {
                    sw.WriteLine(FacturaDetalle.IdFacturaDetalle + ";" +
                    FacturaDetalle.IdFactura + ";" +
                    FacturaDetalle.IdProducto + ";" +
                    FacturaDetalle.CantidadProducto + ";" +
                    FacturaDetalle.PrecioProducto + ";" +
                    FacturaDetalle.Valor);
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

        public List<FacturaDetalle> leer()
        {

            List<FacturaDetalle> lista = new List<FacturaDetalle>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    FacturaDetalle p = new FacturaDetalle();
                    p.IdFacturaDetalle = long.Parse(array[0]);
                    p.IdFactura = long.Parse(array[1]);
                    p.IdProducto = long.Parse(array[2]);
                    p.CantidadProducto = int.Parse(array[3]);
                    p.PrecioProducto = double.Parse(array[4]);
                    p.Valor = double.Parse(array[5]);

                    // A la lista vacia le meto la factura detalle 
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



   
