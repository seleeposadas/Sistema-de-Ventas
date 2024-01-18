using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Entidades
{
    public class Usuario
    {
        //ATRIBUTOS
        private int idUsuario;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasenia;
        private string mail;


        //CONSTRUCTOR
        public Usuario(int idUsuario, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.mail = mail;
        }


        //METODOS GET AND SET
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
        public string Mail { get { return mail; } set { mail = value; } }

    }
}
