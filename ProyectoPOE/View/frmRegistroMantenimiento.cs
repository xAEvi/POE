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
    }
}
