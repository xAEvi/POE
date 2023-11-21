using frmMain.Model;
using ProyectoPOE.Controller;
using System;

namespace frmMain.Controller
{
    public class ControllerCliente : ICRUDController<Cliente>
    {
        private List<Cliente> ListaCliente;
        public ControllerCliente()
        {
            ListaCliente = new List<Cliente>();
        }

        public void Crear(Cliente dato)
        {
            ListaCliente.Add(dato);
            MessageBox.Show("Cliente agregado con éxito.");
        }

        public Cliente Leer(string cedula)
        {
            int indice = GetIndice(cedula);

            if (indice != -1)
            {
                return ListaCliente[indice];
            }
            else
            {
                return null;
            }
        }

        public void Actualizar(string cedula, Cliente nuevoDato)
        {
            int indice = GetIndice(cedula);

            if (indice != -1)
            {
                ListaCliente[indice] = nuevoDato;
                MessageBox.Show("Cliente ha sido actualizado.");
            } 
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        public void Eliminar(string cedula)
        {
            int indice = GetIndice(cedula);

            if (indice != -1)
            {
                ListaCliente.RemoveAt(indice);
                MessageBox.Show("Cliente ha sido eliminado.");
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }
        public int GetIndice(string cedula)
        {
            return ListaCliente.FindIndex(cliente => cliente.Cedula == cedula);
        }
    }
}
