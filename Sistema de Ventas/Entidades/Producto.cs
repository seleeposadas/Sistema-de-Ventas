﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Entidades
{
    public class Producto
    {
        private int idProducto;
        private string descripcion;
        private float costo;
        private float precioVenta;
        private int stock;
        private int idUsuario;

        public Producto(int idProducto, string descripcion, float costo, float precioVenta, int stock, int idUsuario)
        {

            this.idProducto = idProducto;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }

        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public float Costo { get { return costo; } set { costo = value; } }
        public float PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }

    }
}
