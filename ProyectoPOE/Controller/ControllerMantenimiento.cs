using frmMain.Model;

namespace frmMain.Controller
{
    internal class ControllerMantenimiento
    {
        private List<Mantenimiento> ListaMantenimientos;
        private ControllerMantenimiento()
        {
            ListaMantenimientos = new List<Mantenimiento>();
        }
        public List<Mantenimiento> GetMantenimientos()
        {
            return ListaMantenimientos;
        }
        public void AgregarMantenimiento(Mantenimiento mantenimiento)
        {
            ListaMantenimientos.Add(mantenimiento);
        }
    }
}
