using DemoWebApi.Models;
using DemoWebApi.Models.UnitOfWork;
using System.Linq;

namespace DemoWebApi.Services
{
    public class UsuarioService : IUsuarioService
    {
        
        private readonly UnitOfWork _sUnitOfwork;
        public UsuarioService()
        {
            _sUnitOfwork = new UnitOfWork();
        }
        public Usuario Get(string i)
        {
            return _sUnitOfwork.Usuarios.Get(i);
        }
        public IQueryable<Usuario> GetAll()
        {
            return _sUnitOfwork.Usuarios.GetAll();
        }
        public void Delete(string id)
        {
            _sUnitOfwork.Usuarios.Delete(s => s.Id, id);
        }
        public void Insert(Usuario usuario)
        {
            _sUnitOfwork.Usuarios.Add(usuario);
        }
        public void Update(Usuario usuario)
        {
            _sUnitOfwork.Usuarios.Update(s => s.Id, usuario.Id, usuario);
        }
    }
}