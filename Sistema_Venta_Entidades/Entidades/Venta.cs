using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Entidades
{
    public class Venta
    {
        private int idVenta;
        private string comentarios;
        private int idUsuario;
        private string nombreUsuario;

        public Venta(int idVenta, string comentarios, int idUsuario, string nombreUsuario)
        {
            this.idVenta = idVenta;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;

        }
        public Venta() { }

        public int IdVenta { get { return idVenta; } set { idVenta = value; } }
        public string Comentarios { get { return comentarios; } set { comentarios = value; } }
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
    }
}
