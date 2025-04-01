using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario
{
    internal class Empleado
    {
        // Datos personales
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Contraseña { get; set; }

        // Datos salariales
        public decimal SalarioBase { get; set; }
        public decimal Bonificacion { get; set; }
        // Salario final calculado: base + bonificación
        public decimal SalarioFinal
        {
            get { return SalarioBase + Bonificacion; }
        }

        // Estado del empleado: "Activo" o "Desactivado"
        public string Estado { get; set; }

        // Constructor
        public Empleado(string nombre, string apellido, string telefono, string contraseña, decimal salarioBase, decimal bonificacion = 0)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            // Cifrado de contraseña (ejemplo con Base64, se puede mejorar)
            Contraseña = CifrarContraseña(contraseña);
            SalarioBase = salarioBase;
            Bonificacion = bonificacion;
            Estado = "Activo";
        }

        // Método para cifrar la contraseña
        private string CifrarContraseña(string password)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }

        // Actualizar los datos salariales (sin descuentos)
        public void ActualizarSalario(decimal nuevoSalarioBase, decimal nuevaBonificacion)
        {
            SalarioBase = nuevoSalarioBase;
            Bonificacion = nuevaBonificacion;
        }

        // Alternar estado: desactiva si está activo y viceversa
        public void ToggleEstado()
        {
            if (Estado == "Activo")
                Estado = "Desactivado";
            else
                Estado = "Activo";
        }
    }
}
