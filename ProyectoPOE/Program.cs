using frmMain.Controller;
using frmMain.Model;

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

            Cliente objCliente = new Cliente("Molina", "Xavier", "123", "Pene", "1234");
            Mecanico objMecanico = new Mecanico("Pene", "De vaca", "123", "General", "Matutina");

            clientes.Crear(objCliente);
            mecanicos.Crear(objMecanico);

            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain(clientes, mecanicos, mantenimientos));
        }
    }
}