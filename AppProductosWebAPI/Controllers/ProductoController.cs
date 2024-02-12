using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Ventas.Entidades;
using Sistema_Venta_Negocio;

namespace AppProductosWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProductos")]

        public IEnumerable<Producto> Get()
        {
           return ProductoNegocio.PopularProducto().ToArray();
        }

        [HttpDelete(Name = "EliminarProductos")]

        public void EliminarProductos([FromBody] Producto prod) 
        {
            ProductoNegocio.EliminarProducto(prod);
        }

        [HttpPut(Name = "ActualizarProductos")]

        public void ActualizarProducto([FromBody] Producto prod) 
        {
            ProductoNegocio.ActualizarProducto(prod);
        }

        [HttpPost(Name = "RegistrarProducto")]

        public void RegistrarProducto([FromBody] Producto prod) 
        {
            ProductoNegocio.RegistrarProducto(prod);
        }
    }
}
