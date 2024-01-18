using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Entidades
{
    public class ProductoVendido
    {
        private int idProductoVendido;
        private int idProducto;
        private int stock;
        private int idVenta;

        public ProductoVendido(int idProductoVendido, int idProducto, int stock, int idVenta)
        {

            this.idProductoVendido = idProductoVendido;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }

        public int IdProductoVendido { get { return idProductoVendido; } set { idProductoVendido = value; } }
        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public int IdVenta { get { return idVenta; } set { idVenta = value; } }
    }
}
