using frmMain.Model;

namespace frmMain.Controller
{
    public class ControllerMecanico
    {
        private List<Mecanico> ListaMecanico;
        public ControllerMecanico()
        {
            ListaMecanico = new List<Mecanico>();
        }
        public List<Mecanico> GetMecanico()
        {
            return ListaMecanico;
        }
        public void AgregarMecanico(Mecanico mecanico)
        {
            ListaMecanico.Add(mecanico);
        }
    }
}
