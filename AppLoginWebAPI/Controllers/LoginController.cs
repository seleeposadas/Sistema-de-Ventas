using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Venta_Negocio;

namespace AppLoginWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet(Name = "GetInicioSesion")]
        public IActionResult TraerUsuarioxLogin(string usuario, string password)
        {
            var usuarioEncontrado = UsuarioNegocio.Login(usuario, password);

            if (usuarioEncontrado.NombreUsuario != null)
            {
                return Ok("Usuario: " + usuarioEncontrado.NombreUsuario);
            }
            else
            {
                return NotFound(new { message = "Usuario no encontrado. Usuario o Contraseña Inválido" });
            }
        }
    }
}
