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
    public class ClienteGestion
    {

        public List<Cliente> lista;

        ClienteDatos datos = new ClienteDatos();

        public ClienteGestion()
        {
            this.lista = datos.leer();
        }

        public long guardar(Cliente cliente)
        {
            Cliente p = buscarPorCedula(cliente.Cedula);
            if (p == null)
            {
                cliente.IdPersona = DateTime.Now.Ticks;
                lista.Add(cliente);
                datos.guardar(lista);
                return cliente.IdPersona;
            }
            else
            {
                return p.IdPersona;
            }
        }

        public Cliente buscar(long idCliente)
        {
            foreach (Cliente cliente in lista)
            {
                if (cliente.IdPersona.Equals(idCliente))
                {
                    return cliente;
                }
            }
            return null;
        }

        public Cliente buscarPorCedula(string Cedula)
        {
            foreach (Cliente cliente in lista)
            {
                if (cliente.Cedula.Equals(Cedula))
                {
                    return cliente;
                }
            }
            return null;
        }

        public string eliminar(string Cedula)
        {
            int cont = 0;
            foreach (Cliente cliente in lista)
            {
                if (cliente.Cedula.Equals(Cedula))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminado exitosamente";
                }
                cont++;
            }
            return "No se encontro el cliente con esta identificacion";
        }
    }

}

