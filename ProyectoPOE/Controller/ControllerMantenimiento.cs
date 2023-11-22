using frmMain.Model;
using ProyectoPOE.Controller;

namespace frmMain.Controller
{
    public class ControllerMantenimiento : ICRUDController<Mantenimiento>
    {
        public List<Mantenimiento> ListaMantenimientos;
        public ControllerMantenimiento()
        {
            ListaMantenimientos = new List<Mantenimiento>();
        }
        public List<Mantenimiento> GetMantenimientos()
        {
            return ListaMantenimientos;
        }

        public void Crear(Mantenimiento mantenimiento)
        {
            ListaMantenimientos.Add(mantenimiento);
            MessageBox.Show("Mantenimiento agregado con éxito.");
        }

        public Mantenimiento Leer(string id)
        {
            int indice = GetIndice(id);

            if (indice != -1)
            {
                return ListaMantenimientos[indice];
            }
            else
            {
                return null;
            }
        }

        public void Actualizar(string id, Mantenimiento nuevoDato)
        {
            int indice = GetIndice(id);

            if (indice != -1)
            {
                ListaMantenimientos[indice] = nuevoDato;
                MessageBox.Show("Mantenimiento actualizado.");
            }
            else
            {
                MessageBox.Show("No se pudo modificar el mantenimiento");
            }
        }

        public void Eliminar(string id)
        {
            int indice = GetIndice(id);

            if (indice != -1)
            {
                ListaMantenimientos.RemoveAt(indice);
                MessageBox.Show("Mantenimiento eliminado.");
            }
            else
            {
                MessageBox.Show("Mantenimiento no encontrado.");
            }
        }

        public int GetIndice(string id)
        {
            return ListaMantenimientos.FindIndex(mantenimiento => mantenimiento.Codigo == id);
        }
    }
}
