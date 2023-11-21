using frmMain.Model;

namespace frmMain.Controller
{
    internal class ControllerMecanico
    {
        private List<Mecanico> ListaMecanico;
        private ControllerMecanico()
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
