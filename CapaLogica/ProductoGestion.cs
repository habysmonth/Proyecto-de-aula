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
    public class ProductoGestion
    {
        public List<Producto> lista;

        ProductoDatos datos = new ProductoDatos();

        public ProductoGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Producto producto)
        {
            Producto p = buscar(producto.IdProducto);
            if (p == null)
            {
                producto.IdProducto = DateTime.Now.Ticks;
                lista.Add(producto);
                datos.guardar(lista);
                return "Producto almacenado exitosamente";
            }
            else
            {
                return "La identificacion ya existe en un producto previamente registrado";
            }
        }

        public Producto buscarPorCodigo(string Codigo)
        {
            foreach (Producto producto in lista)
            {
                if (producto.Codigo.Equals(Codigo))
                {
                    return producto;
                }
            }
            return null;
        }

        public Producto buscar(long IdProducto)
        {
            foreach (Producto producto in lista)
            {
                if (producto.IdProducto.Equals(IdProducto))
                {
                    return producto;
                }
            }
            return null;
        }

        public bool ValidarCodigoExiste(string codigo)
        {
            foreach (Producto producto in lista)
            {
                if (producto.Codigo.Equals(codigo))
                {
                    return true;
                }
            }
            return false;
        }



        public string eliminar(string IdProducto)
        {
            int cont = 0;
            foreach (Producto producto in lista)
            {
                if (producto.IdProducto.Equals(IdProducto))
                {
                    lista.RemoveAt(cont);
                    datos.guardar(lista);
                    return "Eliminado exitosamente";
                }
                cont++;
            }
            return "No se encontro el cliente con esta identificacion";
        }



        public string actualizar(string codigo, Producto nuevoProducto)
        {
            List<Producto> listaTemporal = new List<Producto>();
            foreach (Producto producto in lista)
            {
                if (producto.Codigo.Equals(codigo))
                {
                    listaTemporal.Add(nuevoProducto);
                }
                else
                {
                    listaTemporal.Add(producto);
                }
            }
            this.lista = listaTemporal;
            datos.guardar(this.lista);
            return "Prodcuto actualizado exitosamente";
        }

    }
}

