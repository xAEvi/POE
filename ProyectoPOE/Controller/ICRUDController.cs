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
        T Leer(string indice);
        void Actualizar(string indice, T dato);
        void Eliminar(string indice);
    }
}
