using DemoWebApi.Models;
using System.Linq;

namespace DemoWebApi.Services
{
    public interface IUsuarioService
    {
        void Insert(Usuario usuario);
        Usuario Get(string i);
        IQueryable<Usuario> GetAll();
        void Delete(string id);
        void Update(Usuario usuario);
    }
}