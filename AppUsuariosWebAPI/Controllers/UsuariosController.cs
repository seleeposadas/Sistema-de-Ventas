using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Ventas.Entidades;
using Sistema_Venta_Negocio;

namespace AppUsuariosWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioNegocio.PopularUsuarios().ToArray();
        }

        [HttpDelete(Name = "EliminarUsuarios")]
        public void EliminarUsuario([FromBody] Usuario usu)
        {
            UsuarioNegocio.EliminarUsuario(usu);
        }

        [HttpPut(Name = "ActualizarUsuario")]
        public void ActualizarUsuario([FromBody] Usuario usu)
        {
            UsuarioNegocio.ActualizarUsuario(usu);
        }

        [HttpPost(Name = "RegistrarUsuarios")]
        public void RegistrarUsuario([FromBody] Usuario usu)
        {
            UsuarioNegocio.RegistrarUsuario(usu);
        }

    }
}
