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
    public class UsuarioGestion
    {
        public List<Usuario> lista;

        UsuarioDatos datos = new UsuarioDatos();

        public UsuarioGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Usuario usuario)
        {
            usuario.IdPersona = DateTime.Now.Ticks;
            lista.Add(usuario);
            datos.guardar(lista);
            return "Usuario almacenado exitosamente";
        }

        public Usuario buscar(long Cedula)
        {
            foreach (Usuario usuario in lista)
            {
                if (usuario.Cedula.Equals(Cedula))
                {
                    return usuario;
                }
            }
            return null;
        }
        public Usuario buscarPorUsername(string username)
        {
            foreach (Usuario usuario in lista)
            {
                if (usuario.username.Equals(username))
                {
                    return usuario;
                }
            }
            return null;
        }




        public string eliminar(long Cedula)
        {
            int cont = 0;
            foreach (Usuario usuario in lista)
            {
                if (usuario.Cedula.Equals(usuario))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminado exitosamente";
                }
                cont++;
            }
            return "No se encontro usuario con esta identificacion";
        }

        public string actualizar(long IdUsuario, Usuario nuevoUsuario)
        {
            List<Usuario> listaTemporal = new List<Usuario>();
            foreach (Usuario usuario in lista)
            {
                if (usuario.IdPersona.Equals(IdUsuario))
                {
                    listaTemporal.Add(nuevoUsuario);
                }
                else
                {
                    listaTemporal.Add(usuario);
                }
            }
            this.lista = listaTemporal;
            datos.guardar(this.lista);
            return "Usuario actualizado exitosamente";
        }



        public bool login(string nomusuario, string clave)
        {
            foreach (Usuario usuario in lista)
            {
                if (usuario.username.Equals(nomusuario) && usuario.password.Equals(clave) && usuario.Perfil == "usuario")
                {
                    return true;
                }
            }
            return false;
        }
    }
}

