using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;

namespace AppProductosVendidosWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosVendidosController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]

        public IEnumerable<ProductoVendido> Get() 
        {
            return ProductoVendidoData.PopularProductoVendido().ToArray();
        }

        [HttpDelete (Name ="EliminarProductoVendido")]

        public void EliminarProductoVendido([FromBody] ProductoVendido prodVen)
        {
            ProductoVendidoData.EliminarProducto(prodVen);
        }

        [HttpPut (Name = "ModificarProductoVendido")]

        public void ActualizarProductoVendido ([FromBody] ProductoVendido prodVen)
        {
            ProductoVendidoData.ActualizarProductoVendido(prodVen);
        }
        [HttpPost (Name = "RegistrarProductoVendido")]

        public void RegistrarProductoVendido([FromBody] ProductoVendido prodVen)
        {
            ProductoVendidoData.RegistrarProductoVendido(prodVen);
        }
    }
}
