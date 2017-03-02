using System.Linq;
using System.Web.Http;
using DemoWebApi.Models;
using DemoWebApi.Services;
using System.Net.Http;
using System.Net;

namespace DemoWebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }

        // GET api/student/id
        public HttpResponseMessage Get(string id)
        {
            var usuario = _usuarioService.Get(id);
            if (usuario != null)
                return Request.CreateResponse(HttpStatusCode.OK, usuario);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound,"No existe usuario con id indicado");
        }

        public HttpResponseMessage GetAll()
        {
            var usuarios = _usuarioService.GetAll();
            if (usuarios.Any())
                return Request.CreateResponse(HttpStatusCode.OK, usuarios);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound,"No existen usuarios");
        }

        public void Post([FromBody]Usuario usuario)
        {
            _usuarioService.Insert(usuario);
        }
        public void Delete(string id)
        {
            _usuarioService.Delete(id);
        }
        public void Put([FromBody]Usuario usuario)
        {
            _usuarioService.Update(usuario);
        }
    }
}