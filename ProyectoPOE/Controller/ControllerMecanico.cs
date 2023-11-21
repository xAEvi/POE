using frmMain.Model;
using ProyectoPOE.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frmMain.Controller
{
    public class ControllerMecanico : ICRUDController<Mecanico>
    {
        private List<Mecanico> ListaMecanico;

        public ControllerMecanico()
        {
            ListaMecanico = new List<Mecanico>();
        }

        public List<Mecanico> GetMecanicos()
        {
            return ListaMecanico;
        }

        public void Crear(Mecanico dato)
        {
            ListaMecanico.Add(dato);
            MessageBox.Show("Mecánico agregado con éxito.");
        }

        public Mecanico Leer(string cedula)
        {
            int indice = GetIndice(cedula);

            if (indice != -1)
            {
                return ListaMecanico[indice];
            }
            else
            {
                return null;
            }
        }

        public void Actualizar(string cedula, Mecanico nuevoDato)
        {
            int indice = GetIndice(cedula);

            if (indice != -1)
            {
                ListaMecanico[indice] = nuevoDato;
                MessageBox.Show("Mecánico ha sido actualizado.");
            }
            else
            {
                MessageBox.Show("Mecánico no encontrado.");
            }
        }

        public void Eliminar(string cedula)
        {
            int indice = GetIndice(cedula);

            if (indice != -1)
            {
                ListaMecanico.RemoveAt(indice);
                MessageBox.Show("Mecánico ha sido eliminado.");
            }
            else
            {
                MessageBox.Show("Mecánico no encontrado.");
            }
        }

        public int GetIndice(string cedula)
        {
            return ListaMecanico.FindIndex(mecanico => mecanico.Cedula == cedula);
        }
    }
}
