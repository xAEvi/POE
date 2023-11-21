using frmMain.Controller;
using frmMain.Model;
using GestorMantenimientosTaller.View;
using ProyectoPOE.View;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        private ControllerCliente clientes;
        private ControllerMecanico mecanicos;
        private ControllerMantenimiento mantenimientos;
        public frmMain(ControllerCliente clientes, ControllerMecanico mecanicos, ControllerMantenimiento mantenimientos)
        {
            this.clientes = clientes;
            this.mecanicos = mecanicos;
            this.mantenimientos = mantenimientos;
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca formulario = new frmAcerca();
            formulario.Show();
        }


        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCliente formulario = new frmRegistroCliente(clientes);
            formulario.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroMecanico formulario = new frmRegistroMecanico(mecanicos);
            formulario.Show();
        }

        private void nuevoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroMantenimiento formulario = new frmRegistroMantenimiento(mantenimientos);
            formulario.Show();
        }
    }
}