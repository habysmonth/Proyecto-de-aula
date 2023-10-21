using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TipoHabitacion
    {
        public long IdTipoHabitacion { get; set; }
        public long IdHotel { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
