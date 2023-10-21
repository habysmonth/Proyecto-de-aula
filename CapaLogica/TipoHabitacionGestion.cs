using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class TipoHabitacionGestion
    {
        public List<TipoHabitacion> lista;

        TipoHabitacionDatos datos = new TipoHabitacionDatos();

        public TipoHabitacionGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(TipoHabitacion tipoHabitacion)
        {
            tipoHabitacion.IdTipoHabitacion = DateTime.Now.Ticks;
            lista.Add(tipoHabitacion);
            datos.guardar(lista);
            return "Tipo de habitacion almacenado exitosamente";
        }

        public TipoHabitacion buscar(long IdTipoHabitacion)
        {
            foreach (TipoHabitacion tipoHabitacion in lista)
            {
                if (tipoHabitacion.IdTipoHabitacion.Equals(IdTipoHabitacion))
                {
                    return tipoHabitacion;
                }
            }
            return null;
        }

        public TipoHabitacion buscarPorDesc(string descripcion)
        {
            foreach (TipoHabitacion tipoHabitacion in lista)
            {
                if (tipoHabitacion.Descripcion.Equals(descripcion))
                {
                    return tipoHabitacion;
                }
            }
            return null;
        }
        public string actualizar(long IdTipoHabitacion, TipoHabitacion nuevoTipoHabitacion)
        {
            List<TipoHabitacion> listaTemporal = new List<TipoHabitacion>();
            foreach (TipoHabitacion tipohabitacion in lista)
            {
                if (tipohabitacion.IdTipoHabitacion.Equals(IdTipoHabitacion))
                {
                    listaTemporal.Add(nuevoTipoHabitacion);
                }
                else
                {
                    listaTemporal.Add(tipohabitacion);
                }
            }
            this.lista = listaTemporal;
            datos.guardar(this.lista);
            return "Tipo de Habitación actualizado exitosamente";
        }

        public string eliminar(long IdTipoHabitacion)
        {
            int cont = 0;
            foreach (TipoHabitacion tipoHabitacion in lista)
            {
                if (tipoHabitacion.IdTipoHabitacion.Equals(tipoHabitacion))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminada exitosamente";
                }
                cont++;
            }
            return "No se encontro tipo de habitacion con esta identificacion";
        }
    }
}

