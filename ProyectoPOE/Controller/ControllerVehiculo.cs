using frmMain.Model;

namespace frmMain.Controller
{
    internal class ControllerVehiculo
    {
        private List<Vehiculo> Vehiculos { get; set; }
        
        private ControllerVehiculo()
        {
            Vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }

    }
}
