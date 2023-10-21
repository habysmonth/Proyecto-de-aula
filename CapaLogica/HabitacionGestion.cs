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
    public class HabitacionGestion
    {
        public List<Habitacion> lista;

        HabitacionDatos datos = new HabitacionDatos();

        public HabitacionGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Habitacion habitacion)
        {
            habitacion.IdHabitacion = DateTime.Now.Ticks;
            lista.Add(habitacion);
            datos.guardar(lista);
            return "Habitacion almacenada exitosamente";
        }

        public Habitacion buscar(long IdHabitacion)
        {
            foreach (Habitacion habitacion in lista)
            {
                if (habitacion.IdHabitacion.Equals(IdHabitacion))
                {
                    return habitacion;
                }
            }
            return null;
        }

        public Habitacion buscarPorNumHab(int NumeroHabitacion)
        {
            foreach (Habitacion habitacion in lista)
            {
                if (habitacion.NumeroHabitacion.Equals(NumeroHabitacion))
                {
                    return habitacion;
                }
            }
            return null;
        }


        public string actualizar(long IdHabitacion, Habitacion nuevaHabitacion)
        {
            List<Habitacion> listaTemporal = new List<Habitacion>();
            foreach (Habitacion habitacion in lista)
            {
                if (habitacion.IdHabitacion.Equals(IdHabitacion))
                {
                    listaTemporal.Add(nuevaHabitacion);
                }
                else
                {
                    listaTemporal.Add(habitacion);
                }
            }
            this.lista = listaTemporal;
            datos.guardar(this.lista);
            return "Habitación actualizada exitosamente";
        }


        public string eliminar(long IdHabitacion)
        {
            int cont = 0;
            foreach (Habitacion habitacion in lista)
            {
                if (habitacion.IdHabitacion.Equals(IdHabitacion))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminada exitosamente";
                }
                cont++;
            }
            return "No se encontro la Habitacion con esta identificacion";
        }
    }

}

