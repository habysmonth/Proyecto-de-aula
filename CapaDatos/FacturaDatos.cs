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
    public class FacturaDatos
    {
        string archivo = "Factura.txt";
        public bool guardar(List<Factura> facturas)
        {
            try
            {
                File.Delete(archivo);
                StreamWriter sw = new StreamWriter(archivo);
                foreach (Factura factura in facturas)
                {
                    sw.WriteLine(factura.IdFactura + ";" +
                    factura.IdCliente + ";" +
                    factura.FechaFacturacion + ";" +
                    factura.TotalCuenta); 
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

        public List<Factura> leer()
        {

            List<Factura> lista = new List<Factura>();

            string linea;
            try
            {
                StreamReader sr = new StreamReader(archivo);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] array = linea.Split(';');
                    Factura p = new Factura();
                    p.IdFactura = long.Parse(array[0]); 
                    p.IdCliente = long.Parse(array[1]);
                    p.FechaFacturacion = DateTime.Parse(array[2]);
                    p.TotalCuenta = double.Parse(array[3]);
                   
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

