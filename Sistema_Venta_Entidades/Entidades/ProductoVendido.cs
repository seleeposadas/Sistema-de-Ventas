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
        private string descripcion;
        private int stock;
        private int idVenta;
        private string comentario;

        public ProductoVendido(int idProductoVendido, int idProducto, string descripcion, int stock, int idVenta, string comentario)
        {

            this.idProductoVendido = idProductoVendido;
            this.idProducto = idProducto;
            this.descripcion = descripcion;
            this.stock = stock;
            this.idVenta = idVenta;
            this.comentario = comentario;
        }

        public ProductoVendido() { }

        public int IdProductoVendido { get { return idProductoVendido; } set { idProductoVendido = value; } }
        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public int IdVenta { get { return idVenta; } set { idVenta = value; } }
        public string Comentario { get {  return comentario; } set {  comentario = value; } }
    }
}
