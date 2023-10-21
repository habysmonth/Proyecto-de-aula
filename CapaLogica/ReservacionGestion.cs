using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesPadres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ReservacionGestion
    {
        public List<Reservacion> lista;

        ReservacionDatos datos = new ReservacionDatos();

        public ReservacionGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Reservacion reservacion)
        {
            reservacion.NumeroReserva = DateTime.Now.Ticks;
            lista.Add(reservacion);
            datos.guardar(lista);
            return "Reserva almacenada exitosamente con num reserva: " + reservacion.NumeroReserva;
        }

        public Reservacion buscar(long NumeroReserva)
        {
            foreach (Reservacion reservacion in lista)
            {
                if (reservacion.NumeroReserva.Equals(NumeroReserva))
                {
                    return reservacion;
                }
            }
            return null;
        }

        public string eliminar(long NumeroReserva)
        {
            int cont = 0;
            foreach (Reservacion reservacion in lista)
            {
                if (reservacion.NumeroReserva.Equals(NumeroReserva))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminado exitosamente";
                }
                cont++;
            }
            return "No se encontro el cliente con esta identificacion";
        }

        public string actualizar(long NumeroReserva, Reservacion nuevaReservacion)
        {
            List<Reservacion> temporal = new List<Reservacion>();
            foreach (Reservacion reservacion in lista)
            {
                if (reservacion.NumeroReserva.Equals(NumeroReserva))
                {
                    temporal.Add(nuevaReservacion);
                }
                else
                {
                    temporal.Add(reservacion);
                }
            }
            this.lista = temporal;
            datos.guardar(lista);
            return "Actualizacion exitosa";
        }

        public String ValidarHabitacion(long idHabitacion)
        {
            DateTime fechaActual = DateTime.Now;    
            foreach (Reservacion reservacion in lista)
            {
                if(reservacion.Estado != "Cancelada")
                {
                    if (reservacion.IdHabitacion.Equals(idHabitacion))
                    {
                        if (reservacion.FechaInicio <= fechaActual && reservacion.FechaFin >= fechaActual)
                        {
                            return "Ocupada";
                        }
                    }
                }
                
            }
            return "Libre";
        }
    }
}

