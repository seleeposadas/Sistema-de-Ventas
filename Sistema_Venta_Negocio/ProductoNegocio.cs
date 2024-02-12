using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Venta_Negocio
{
    public static class ProductoNegocio
    {
        public static void RegistrarProducto(Producto prod)
        {
            ProductoData.RegistrarProducto(prod);
        }
        public static void ActualizarProducto(Producto prod)
        {
            ProductoData.ActualizarProducto(prod);
        }
        public static void EliminarProducto(Producto prod)
        {
            ProductoData.EliminarProducto(prod);
        }
        public static List<Producto> PopularProducto()
        {
            return ProductoData.PopularProducto();
        }

        public static Producto ObtenerProductoxId(int IdProducto)
        {
            return ProductoData.ObtenerProductoxId(IdProducto);
        }

    }
}
