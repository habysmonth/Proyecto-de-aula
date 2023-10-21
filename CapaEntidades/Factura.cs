using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesHijas
{
    public class Factura
    {
        public long IdFactura { get; set; }
        public long IdCliente { get; set; }
        public DateTime FechaFacturacion { get; set; } = DateTime.Now;
        public double TotalCuenta { get; set; }

        public Factura()
        {

        }
    }
}
