using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class PersonaGestion
    {
        public List<Persona> lista;

        PersonaDatos datos = new PersonaDatos();

        public PersonaGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Persona persona)
        {
            Persona p = buscar(persona.Cedula);
            if (p == null)
            {
                persona.IdPersona = DateTime.Now.Ticks;
                lista.Add(persona);
                datos.guardar(lista);
                return "Persona almacenado exitosamente";
            }
            else
            {
                return "La identificacion ya existe en una persona previamente registrado";
            }
        }

        public Persona buscar(string Cedula)
        {
            foreach (Persona persona in lista)
            {
                if (persona.Cedula.Equals(Cedula))
                {
                    return persona;
                }
            }
            return null;
        }

        public string eliminar(string Cedula)
        {
            int cont = 0;
            foreach (Persona persona in lista)
            {
                if (persona.Cedula.Equals(Cedula))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminado exitosamente";
                }
                cont++;
            }
            return "No se encontro una persona con esta identificacion";
        }
    }
}

