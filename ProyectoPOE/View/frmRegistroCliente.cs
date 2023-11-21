using frmMain.Controller;
using frmMain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorMantenimientosTaller.View
{
    public partial class frmRegistroCliente : Form
    {
        bool banderanuevo = false;
        ControllerCliente ControllerCli = new ControllerCliente();


        public frmRegistroCliente()
        {
            InitializeComponent();

        }

        private void SetearFormulario()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;

        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            if (banderanuevo)
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtdireccion.Enabled = true;
                txtCedula.Enabled = true;
                txtTelefono.Enabled = true;

                string nombres = txtNombre.Text;
                string apellidos = txtApellido.Text;
                string direccion = txtdireccion.Text;
                string cedula = txtCedula.Text;
                string telefono = txtTelefono.Text;
                Cliente objCliente = new Cliente(apellidos, nombres, cedula, direccion, telefono);
                ControllerCli.AgregarCliente(objCliente);
                MessageBox.Show("Cliente Grabada con exito");
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtdireccion.Text = string.Empty;
                txtCedula.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;

                banderanuevo = false;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            SetearFormulario();
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            banderanuevo = true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo números y teclas de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Limitar a 10 caracteres
                if (txtCedula.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo números y teclas de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Limitar a 10 caracteres
                if (txtTelefono.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}

