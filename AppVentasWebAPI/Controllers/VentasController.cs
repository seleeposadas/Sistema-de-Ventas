using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Ventas.Entidades;
using Sistema_Venta_Negocio;

namespace AppVentasWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        [HttpGet(Name = "GetVentasRealizadas")]

        public IEnumerable<Venta> Get()
        {
            return VentaNegocio.PopularVenta().ToArray();
        }

        [HttpDelete (Name = "EliminarVenta")]

        public void EliminarVenta([FromBody] Venta ven)
        {
            VentaNegocio.EliminarVenta(ven);
        }

        [HttpPut(Name = "ActualizarVenta")]

        public void ActualizarVenta([FromBody] Venta venta)
        {
            VentaNegocio.ActualizarVenta(venta);
        }

        [HttpPost (Name = "RegistrarVenta")]

        public void InsertarVenta([FromBody] Venta ven)
        {
            VentaNegocio.RegistrarVenta(ven);
        }
    }
}
