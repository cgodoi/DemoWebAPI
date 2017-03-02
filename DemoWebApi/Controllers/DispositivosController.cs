using System.Linq;
using System.Web.Http;
using DemoWebApi.Models;
using DemoWebApi.Services;
using System.Net.Http;
using System.Net;

namespace DemoWebApi.Controllers
{
    public class DispositivoController : ApiController
    {
        private readonly IDispositivoService _dispositivoService;
        public DispositivoController()
        {
            _dispositivoService = new DispositivoService();
        }

        // GET api/student/id
        public HttpResponseMessage Get(string id)
        {
            var dispositivo = _dispositivoService.Get(id);
            if (dispositivo != null)
                return Request.CreateResponse(HttpStatusCode.OK, dispositivo);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound,"No existe dispositivo con id indicado");
        }

        public HttpResponseMessage GetAll()
        {
            var dispositivos = _dispositivoService.GetAll();
            if (dispositivos.Any())
                return Request.CreateResponse(HttpStatusCode.OK, dispositivos);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound,"No existen dispositivos");
        }

        public void Post([FromBody]Dispositivo dispositivo)
        {
            _dispositivoService.Insert(dispositivo);
        }
        public void Delete(string id)
        {
            _dispositivoService.Delete(id);
        }
        public void Put([FromBody]Dispositivo dispositivo)
        {
            _dispositivoService.Update(dispositivo);
        }
    }
}