using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace modulo_inventario
{
    public partial class RecursosHumanos : Form
    {
        // Lista en memoria para almacenar los empleados
        private List<Empleado> empleados = new List<Empleado>();

        public RecursosHumanos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.MultiSelect = false;
        }

        // Configuración inicial del DataGridView
        private void ConfigurarDataGridView()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido"
            });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono"
            });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SalarioBase",
                HeaderText = "Salario Base"
            });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Bonificacion",
                HeaderText = "Bonificación"
            });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SalarioFinal",
                HeaderText = "Salario Final"
            });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado"
            });
        }

        // Actualiza el DataGridView con la lista de empleados
        private void MostrarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;
        }

        // Limpia los TextBox después de agregar o editar
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtContrasena.Clear();
            txtSalarioBase.Clear();
            txtBonificacion.Clear();
        }


        // Botón: Editar Empleado (datos personales)
        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellido.Text) ||
            string.IsNullOrWhiteSpace(txtTelefono.Text) ||
            txtTelefono.Text.Length != 8)  // Verificar que el teléfono tenga 8 dígitos
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos (Nombre, Apellido, Teléfono de 8 dígitos).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int index = dgvEmpleados.SelectedRows[0].Index;
                Empleado empleadoSeleccionado = empleados[index];

                // Actualizar datos personales
                empleadoSeleccionado.Nombre = txtNombre.Text;
                empleadoSeleccionado.Apellido = txtApellido.Text;
                empleadoSeleccionado.Telefono = txtTelefono.Text;
                // Actualizamos la contraseña y se cifra nuevamente
                empleadoSeleccionado.Contraseña = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtContrasena.Text));

                MostrarEmpleados();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para editar.");
            }
        }



        // Botón: Alternar Estado (Activo/Desactivado)
        private void btnToggleEstado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int index = dgvEmpleados.SelectedRows[0].Index;
                Empleado empleadoSeleccionado = empleados[index];

                // Alternar el estado del empleado
                empleadoSeleccionado.ToggleEstado();
                MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para cambiar su estado.");
            }
        }

        // Evento: Doble clic en el DataGridView para cargar los datos en los TextBox
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < empleados.Count)
            {
                Empleado empleadoSeleccionado = empleados[e.RowIndex];

                txtNombre.Text = empleadoSeleccionado.Nombre;
                txtApellido.Text = empleadoSeleccionado.Apellido;
                txtTelefono.Text = empleadoSeleccionado.Telefono;
                // Por seguridad, se deja vacío el campo de contraseña al cargar
                txtContrasena.Text = "";
                txtSalarioBase.Text = empleadoSeleccionado.SalarioBase.ToString();
                txtBonificacion.Text = empleadoSeleccionado.Bonificacion.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Puedes dejarlo vacío o personalizar el dibujo del panel.
        }
        private bool ValidarTelefono(string telefono)
        {
            // Se permite vacío si se requiere (o cambiar la lógica para que sea obligatorio)
            if (string.IsNullOrWhiteSpace(telefono))
                return false;

            // Expresión regular para 8 dígitos
            return Regex.IsMatch(telefono, @"^\d{8}$");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;
                string contraseña = txtContrasena.Text;
                decimal salarioBase = Convert.ToDecimal(txtSalarioBase.Text);
                decimal bonificacion = string.IsNullOrWhiteSpace(txtBonificacion.Text) ? 0 : Convert.ToDecimal(txtBonificacion.Text);

                // Validar el número de teléfono
                if (!ValidarTelefono(telefono))
                {
                    MessageBox.Show("El número de teléfono debe tener 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear nuevo empleado y agregarlo a la lista.
                // En el constructor se asigna automáticamente "Activo" a la propiedad Estado.
                Empleado nuevoEmpleado = new Empleado(nombre, apellido, telefono, contraseña, salarioBase, bonificacion);
                empleados.Add(nuevoEmpleado);

                MostrarEmpleados();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
  
            
        }

        private void btnCambiarSalario_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int index = dgvEmpleados.SelectedRows[0].Index;
                Empleado empleadoSeleccionado = empleados[index];

                try
                {
                    decimal nuevoSalarioBase = Convert.ToDecimal(txtSalarioBase.Text);
                    decimal nuevaBonificacion = string.IsNullOrWhiteSpace(txtBonificacion.Text) ? 0 : Convert.ToDecimal(txtBonificacion.Text);

                    // Actualizar datos salariales
                    empleadoSeleccionado.ActualizarSalario(nuevoSalarioBase, nuevaBonificacion);

                    MostrarEmpleados();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar salario: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para actualizar el salario.");
            }

        }
    }
}
