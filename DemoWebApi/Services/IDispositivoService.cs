using DemoWebApi.Models;
using System.Linq;

namespace DemoWebApi.Services
{
    public interface IDispositivoService
    {
        void Insert(Dispositivo dispositivo);
        Dispositivo Get(string i);
        IQueryable<Dispositivo> GetAll();
        void Delete(string id);
        void Update(Dispositivo dispositivo);
    }
}