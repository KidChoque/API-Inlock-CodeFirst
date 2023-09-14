using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPICodeFIrst.Domains;
using webAPICodeFIrst.Interfaces;
using webAPICodeFIrst.Repositories;

namespace webAPICodeFIrst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuario _usuarioRepository { get; set; }

        public UsuarioController()
        {

            _usuarioRepository = new UsuarioRepository();
                
        }

        [HttpPost]
        public IActionResult Post(Usuario novoUsuario) 
        {
            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
