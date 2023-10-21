using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPadres
{
    public class Reservacion
    {
        public long NumeroReserva { get; set; }
        public long IdCliente { get; set; }
        public long IdHabitacion { get; set; }
        public int NumeroAdultos { get; set; }
        public int NumeroNiños { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string Estado { get; set; } = "Activo";

        public Reservacion()
        {

        }
    }
}
