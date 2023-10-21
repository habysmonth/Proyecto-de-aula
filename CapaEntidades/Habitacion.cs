using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesHijas
{
    public class Habitacion
    {
        public long IdHabitacion { get; set; } 
        public long IdHotel { get; set; }
        public long IdTipoHabitacion { get; set; }
        public int NumeroHabitacion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; } = "Activa";
    }
}
