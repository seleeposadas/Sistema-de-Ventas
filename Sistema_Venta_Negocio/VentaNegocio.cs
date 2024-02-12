using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta_Negocio
{
    public static class VentaNegocio
    {
        public static void RegistrarVenta(Venta ven)
        {
            VentaData.RegistrarVenta(ven);
        }
        public static void ActualizarVenta(Venta ven)
        {
            VentaData.ActualizarVenta(ven);
        }
        public static void EliminarVenta(Venta ven) 
        {
            VentaData.EliminarVenta(ven);
        }
        public static List<Venta> PopularVenta() 
        {
            return VentaData.PopularVenta();
        }
        public static Venta ObtenerVentaxId(int IdVenta) 
        {
            return VentaData.ObtenerVentaxId(IdVenta);
        }
    }
}
