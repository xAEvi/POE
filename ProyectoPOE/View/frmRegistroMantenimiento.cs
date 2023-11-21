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

        private void rdbCorrectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbMecanico_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
