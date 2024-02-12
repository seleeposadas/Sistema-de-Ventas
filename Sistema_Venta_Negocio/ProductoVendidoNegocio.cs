using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta_Negocio
{
    public static class ProductoVendidoNegocio
    {
        public static void RegistrarProductoVendido(ProductoVendido prod)
        {
            ProductoVendidoData.RegistrarProductoVendido(prod);
        }
        public static void ActualizarProductoVendido(ProductoVendido prod) 
        {
            ProductoVendidoData.ActualizarProductoVendido(prod);
        }
        public static void EliminarProducto(ProductoVendido prod) 
        {
            ProductoVendidoData.EliminarProducto(prod);
        }
        public static List<ProductoVendido> PopularProductoVendido() 
        {
            return ProductoVendidoData.PopularProductoVendido();
        }
        public static ProductoVendido ObtenerProductoVendioxId(int IdProductoVendido)
        {
            return ProductoVendidoData.ObtenerProductoVendioxId(IdProductoVendido);
        }

    }
}
