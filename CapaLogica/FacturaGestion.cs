using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class FacturaGestion
    {
        public List<Factura> lista;

        FacturaDatos datos = new FacturaDatos();

        public FacturaGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Factura factura)
        {
            factura.IdFactura = DateTime.Now.Ticks;
            lista.Add(factura);
            datos.guardar(lista);
            return "Factura almacenada exitosamente";
        }

        public Factura buscar(long IdFactura)
        {
            foreach (Factura factura in lista)
            {
                if (factura.IdFactura.Equals(IdFactura))
                {
                    return factura;
                }
            }
            return null;
        }

        public string eliminar(long IdFactura)
        {
            int cont = 0;
            foreach (Factura factura in lista)
            {
                if (factura.IdFactura.Equals(IdFactura))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminada exitosamente";
                }
                cont++;
            }
            return "No se encontro la factura con esta identificacion";
        }
    }

}

