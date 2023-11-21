using frmMain.Model;

namespace frmMain.Controller
{
    public class ControllerMantenimiento
    {
        private List<Mantenimiento> ListaMantenimientos;
        public ControllerMantenimiento()
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
