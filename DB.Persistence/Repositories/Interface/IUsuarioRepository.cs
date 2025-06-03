using DB.Persistence.Models;

namespace DB.Persistence.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        Usuario GetById(int id);
        IEnumerable<Usuario> GetAll();
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}