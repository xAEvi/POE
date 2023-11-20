using System.Text;

namespace frmMain.Controller
{
    internal class ControllerRepuesto
    {
        // Colección
        private List<Model.Repuesto> repuestos;

        // Constructor 
        public ControllerRepuesto()
        {
            repuestos = new List<Model.Repuesto>();
        }

        // Método -> Registrar un nuevo repuesto
        public void RegistrarRepuesto(string nombre, decimal precio)
        {
            Model.Repuesto nuevoRepuesto = new Model.Repuesto(nombre, precio);
            repuestos.Add(nuevoRepuesto);
        }

        // Método -> Obtener la información de todos los repuestos
        public string ObtenerInformacionRepuestos()
        {
            if (repuestos.Count == 0)
            {
                return "No hay repuestos registrados.";
            }

            StringBuilder infoRepuestos = new StringBuilder("Repuestos Registrados:\n");

            foreach (var repuesto in repuestos)
            {
                infoRepuestos.AppendLine(repuesto.ObtenerInformacionRepuesto());
            }

            return infoRepuestos.ToString();
        }
    }
}
