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
    public partial class frmRegistroMecanico : Form
    {
        bool banderanuevo = false;
        Mecanico mecanicoEncontrado;
        ControllerMecanico mecanico_handler;
        public frmRegistroMecanico(ControllerMecanico mecanicos)
        {
            mecanico_handler = mecanicos;
            InitializeComponent();
        }

        private void btnGuardarMecanico_Click(object sender, EventArgs e)
        {

        }

        private void lbCorreoMecanico_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreMecanico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoMecanico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedulaMecanico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoMecanico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoMecanico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarMecanico_Click_1(object sender, EventArgs e)
        {

        }
    }
}
