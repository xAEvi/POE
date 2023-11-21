using frmMain.Model;
using ProyectoPOE.Controller;
using System;

namespace frmMain.Controller
{
    internal class ControllerCliente : ICRUDController<Cliente>
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
            Cliente clienteEncontrado = ListaCliente.Find(c => c.Cedula == cedula);

            if (clienteEncontrado != null)
            {
                return clienteEncontrado;
            }
            else
            {
                return null;
            }
        }

        public void Actualizar(string cedula, Cliente nuevoDato)
        {
            Cliente clienteEncontrado = Leer(cedula);

            if (clienteEncontrado != null)
            {
                clienteEncontrado = nuevoDato;
                MessageBox.Show("Cliente actualizado con éxito.");
            } 
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        public void Eliminar(string cedula)
        {
            int indice = ListaCliente.FindIndex(cliente => cliente.Cedula == cedula);

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
    }
}
