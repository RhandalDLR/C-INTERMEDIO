
using System.Collections.Generic;

namespace BusManagement.Interfaces
{
    public interface IRepository<T>
    {
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Remover(T entidad);
        List<T> TraerTodos();
        T ObtenerPorId(int id);
    }
}
