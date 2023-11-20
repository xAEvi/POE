using GestorMantenimientosTaller.View;
using ProyectoPOE.View;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca formulario = new frmAcerca();
            formulario.Show();
        }


        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCliente formulario = new frmRegistroCliente();
            formulario.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroMecanico formulario = new frmRegistroMecanico();
            formulario.Show();
        }

        private void nuevoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroMantenimiento formulario = new frmRegistroMantenimiento();
            formulario.Show();
        }
    }
}