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
    public class HotelGestion
    {
        public List<Hotel> lista;

        HotelDatos datos = new HotelDatos();

        public HotelGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Hotel hoteles)
        {
            hoteles.IdHotel = DateTime.Now.Ticks;
            lista.Add(hoteles);
            datos.guardar(lista);
            return "Hotel almacenada exitosamente";
        }

        public Hotel buscar(long IdHotel)
        {
            foreach (Hotel hotel in lista)
            {
                if (hotel.IdHotel.Equals(IdHotel))
                {
                    return hotel;
                }
            }
            return null;
        }

        public string eliminar(long IdHotel)
        {
            int cont = 0;
            foreach (Hotel hotel in lista)
            {
                if (hotel.IdHotel.Equals(IdHotel))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminada exitosamente";
                }
                cont++;
            }
            return "No se encontro el Hotel con esta identificacion";
        }
    }
}

