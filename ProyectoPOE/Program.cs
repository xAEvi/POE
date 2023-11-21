using frmMain.Controller;

namespace WinFormsApp1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            //Base de Datos
            ControllerCliente clientes = new ControllerCliente();
            ControllerMecanico mecanicos = new ControllerMecanico();
            ControllerMantenimiento mantenimientos = new ControllerMantenimiento();

            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain(clientes, mecanicos, mantenimientos));
        }
    }
}