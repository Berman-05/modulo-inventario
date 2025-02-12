using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario
{
    internal class Inventario
    {
        public static List<Productos> listaProductos { get; private set; } = new List<Productos>();

        public void AgregarProducto(Productos producto)
        {
            listaProductos.Add(producto);
        }

        public bool EliminarProducto(int id)
        {
            Productos producto = listaProductos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                listaProductos.Remove(producto);
                return true;
            }
            return false;
        }

        public List<Productos> ObtenerProductos()
        {
            return listaProductos;
        }
    }
}
