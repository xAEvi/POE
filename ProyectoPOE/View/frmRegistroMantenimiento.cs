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
        bool banderanuevo = false;
        Cliente mantenimientoEncontrado;
        ControllerMantenimiento mantenimiento_handler;
        public frmRegistroMantenimiento(ControllerMantenimiento mantenimientos)
        {
            mantenimiento_handler = mantenimientos;
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
