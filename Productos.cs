using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario
{
    internal class Productos
    {
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Proveedor { get; set; } // Nuevo atributo

        private static int contadorId = 1; // Simulación de ID autoincremental
        public static List<Productos> ComprasRealizadas = new List<Productos>();
        public Productos(string nombre,string proveedor, decimal precio, int cantidad)
        {
            Id = contadorId++;
            Nombre = nombre;
            Proveedor = proveedor;
            Precio = precio;
            Cantidad = cantidad;
           
        }
    }
}
