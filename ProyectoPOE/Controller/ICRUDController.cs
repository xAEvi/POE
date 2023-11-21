using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Controller
{
    public interface ICRUDController<T>
    {
        void Crear(T dato);
        T Leer(string dato);
        void Actualizar(string dato, T objeto);
        void Eliminar(string dato);
        int GetIndice(string indice);
    }
}
