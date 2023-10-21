using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class FacturaDetalle
    {
        public long IdFacturaDetalle { get; set; }
        public long IdFactura { get; set; }
        public long IdProducto { get; set; }
        public int CantidadProducto { get; set; }
        public double PrecioProducto { get; set; }
        public double Valor { get; set; }

    }
}
