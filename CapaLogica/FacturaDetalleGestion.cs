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
    public class FacturaDetalleGestion
    {
        public List<FacturaDetalle> lista;

        FacturaDetalleDatos datos = new FacturaDetalleDatos();

        public FacturaDetalleGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(FacturaDetalle facturaDetalles)
        {
            facturaDetalles.IdFacturaDetalle = DateTime.Now.Ticks;
            lista.Add(facturaDetalles);
            datos.guardar(lista);
            return "Factura almacenada exitosamente";
        }

        public FacturaDetalle buscar(long IdFacturaDetalle)
        {
            foreach (FacturaDetalle facturaDetalle in lista)
            {
                if (facturaDetalle.IdFacturaDetalle.Equals(IdFacturaDetalle))
                {
                    return facturaDetalle;
                }
            }
            return null;
        }

        public string eliminar(long IdFacturaDetalle)
        {
            int cont = 0;
            foreach (FacturaDetalle facturaDetalle in lista)
            {
                if (facturaDetalle.IdFactura.Equals(IdFacturaDetalle))
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

