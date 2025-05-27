
using System.Collections.Generic;
using System.Linq;
using BusManagement.Interfaces;

namespace BusManagement.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly List<T> _entidades = new List<T>();

        public void Agregar(T entidad)
        {
            _entidades.Add(entidad);
        }

        public void Actualizar(T entidad)
        {
            var idProp = typeof(T).GetProperty("AsientoId");
            if (idProp == null) return;

            var id = idProp.GetValue(entidad);
            var existente = _entidades.FirstOrDefault(e => idProp.GetValue(e).Equals(id));
            if (existente != null)
            {
                _entidades.Remove(existente);
                _entidades.Add(entidad);
            }
        }

        public void Remover(T entidad)
        {
            _entidades.Remove(entidad);
        }

        public List<T> TraerTodos()
        {
            return _entidades.ToList();
        }

        public T ObtenerPorId(int id)
        {
            var idProp = typeof(T).GetProperty("AsientoId");
            return _entidades.FirstOrDefault(e => (int)idProp.GetValue(e) == id);
        }
    }
}
