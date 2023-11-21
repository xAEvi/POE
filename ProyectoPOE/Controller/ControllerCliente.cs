using frmMain.Model;

namespace frmMain.Controller
{
    internal class ControllerCliente
    {
        private List<Cliente> ListaCliente;
        public ControllerCliente()
        {
            ListaCliente = new List<Cliente>();
        }
        public List<Cliente> GetCliente()
        {
            return ListaCliente;
        }
        public void AgregarCliente(Cliente cliente)
        {
            ListaCliente.Add(cliente);
        }
    }
}
