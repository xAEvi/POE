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
