using DemoWebApi.Models;
using DemoWebApi.Models.UnitOfWork;
using System.Linq;

namespace DemoWebApi.Services
{
    public class DispositivoService : IDispositivoService
    {
        
        private readonly DispositivosUnitOfWork _sUnitOfwork;
        public DispositivoService()
        {
            _sUnitOfwork = new DispositivosUnitOfWork();
        }
        public Dispositivo Get(string i)
        {
            return _sUnitOfwork.Dispositivos.Get(i);
        }
        public IQueryable<Dispositivo> GetAll()
        {
            return _sUnitOfwork.Dispositivos.GetAll();
        }
        public void Delete(string id)
        {
            _sUnitOfwork.Dispositivos.Delete(s => s.Id, id);
        }
        public void Insert(Dispositivo dispositivo)
        {
            _sUnitOfwork.Dispositivos.Add(dispositivo);
        }
        public void Update(Dispositivo dispositivo)
        {
            _sUnitOfwork.Dispositivos.Update(s => s.Id, dispositivo.Id, dispositivo);
        }
    }
}