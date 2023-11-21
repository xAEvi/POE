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
    public partial class frmRegistroMantenimiento : Form
    {
        ControllerCliente clientes;
        ControllerMecanico mecanicos;
        ControllerMantenimiento mantenimientos;
        bool banderanuevo = false;
        Mantenimiento clienteEncontrado;
        ControllerMantenimiento manteniemiento_handler;
        public frmRegistroMantenimiento(ControllerCliente clientes, ControllerMecanico mecanicos, ControllerMantenimiento mantenimientos)
        {
            this.clientes = clientes;
            this.mecanicos = mecanicos;
            this.mantenimientos = mantenimientos;
            InitializeComponent();
        }

        private void frmRegistroMantenimiento_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarMecanicos();
            CargarServicios();
            CargarRespuestos();
        }

        private void CargarServicios()
        {
            // Cambiar esto por un arreglo de objetos Servicio
            // clbServicios.Items.AddRange(new object[] { "Lavado", "Alineación", "Servicio 3", "Servicio 4", "Servicio 5" });
        }

        private void CargarRespuestos()
        {
            // Cambiar esto por un arreglo de objetos Respuestos
            // clbRepuestos.Items.AddRange(new object[] { "Repuesto 1", "Repuesto 2", "Repuesto 3", "Repuesto 4", "Repuesto 5", "Repuesto 6", "Repuesto 7", "Repuesto 8", "Repuesto 9", "Repuesto 10" });
        }

        private void CargarClientes()
        {
            cmbCliente.DataSource = clientes.GetClientes();
            cmbCliente.DisplayMember = "Nombres";
            cmbCliente.ValueMember = "Cedula";

            cmbCliente.Format += (sender, e) =>
            {
                if (e.ListItem is Cliente cliente)
                {
                    e.Value = $"{cliente.Apellidos} {cliente.Nombres}";
                }
            };
        }

        private void CargarMecanicos()
        {
            /*
            cmbCliente.DataSource = mecanicos.GetMecanicos();
            cmbCliente.DisplayMember = "Nombres";
            cmbCliente.ValueMember = "Cedula";

            cmbCliente.Format += (sender, e) =>
            {
                if (e.ListItem is Mecanico mecanico)
                {
                    e.Value = $"{mecanico.Apellidos} {mecanico.Nombres}";
                }
            };
            */
        }

        private void ReiniciarFormulario()
        {
            /* Ejemplo
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            */
        }

        private void DeshabilitarCampos()
        {
            /* Ejemplo (Solo debe quedar codigo para escribir)
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtdireccion.ReadOnly = true;
            txtCedula.ReadOnly = false;
            txtTelefono.ReadOnly = true;
            */
        }

        private void HabilitarCampos()
        {
            /* Ejemplo
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtdireccion.ReadOnly = false;
            txtCedula.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            */
        }

        private void ResetearBotones()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = false;
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            if (banderanuevo)
            {
                /* Ejemplo
                string nombres = txtNombre.Text;
                string apellidos = txtApellido.Text;
                string direccion = txtdireccion.Text;
                string cedula = txtCedula.Text;
                string telefono = txtTelefono.Text;
                Cliente objCliente = new Cliente(apellidos, nombres, cedula, direccion, telefono);
                cliente_handler.Crear(objCliente);
                */

                banderanuevo = false;
                btnNuevo.Visible = true;
                btnCancelar.Visible = false;
            }
            else
            {
                /* Ejemplo
                string nombres = txtNombre.Text;
                string apellidos = txtApellido.Text;
                string direccion = txtdireccion.Text;
                string cedula = txtCedula.Text;
                string telefono = txtTelefono.Text;
                Cliente clienteActualizado = new Cliente(apellidos, nombres, cedula, direccion, telefono);

                cliente_handler.Actualizar(clienteEncontrado.Cedula, clienteActualizado);
                */
            }

            DeshabilitarCampos();
            ReiniciarFormulario();
            ResetearBotones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;

            ReiniciarFormulario();
            HabilitarCampos();

            // Botones
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;

            banderanuevo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*
            string cedula = txtCedula.Text;

            clienteEncontrado = cliente_handler.Leer(cedula);
            */

            if (clienteEncontrado != null)
            {
                HabilitarCampos();

                /*
                txtTelefono.Text = clienteEncontrado.Telefono;
                txtdireccion.Text = clienteEncontrado.Direccion;
                txtApellido.Text = clienteEncontrado.Apellidos;
                txtNombre.Text = clienteEncontrado.Nombres;
                txtCedula.Text = clienteEncontrado.Cedula;
                */

                banderanuevo = false;

                // Botones
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este manteniemiento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*
                string cedula = txtCedula.Text;

                cliente_handler.Eliminar(cedula);
                */
                ResetearBotones();
                ReiniciarFormulario();
                DeshabilitarCampos();
            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo números y teclas de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void soloAlfabeto(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es una letra y no es un control (como la tecla de retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = true;
            btnCancelar.Visible = false;

            ResetearBotones();
            ReiniciarFormulario();
            banderanuevo = false;
        }

        private void rdbCorrectivo_CheckedChanged(object sender, EventArgs e)
        {
            repuestosBox.Visible = true;
        }

        private void rdbPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            repuestosBox.Visible = false;
        }
    }
}
