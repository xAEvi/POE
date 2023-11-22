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

            Cliente objCliente = new Cliente("Molina", "Xavier", "0750920159", "Pene", "0959538700");
            Mecanico objMecanico = new Mecanico("Duchi", "Walter", "0912559987", "Mecánico General", "Matutina");

            clientes.Crear(objCliente);
            mecanicos.Crear(objMecanico);

            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain(clientes, mecanicos, mantenimientos));
        }
    }
}