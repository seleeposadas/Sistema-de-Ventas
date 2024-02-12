using PE2_acceso_datos.Acceso_Datos;
using Sistema_de_Ventas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta_Negocio
{
    public static class UsuarioNegocio
    {
        public static void RegistrarUsuario(Usuario usu) 
        {
            UsuarioData.RegistrarUsuario(usu); 
        }
        public static void ActualizarUsuario(Usuario usu)
        {
            UsuarioData.ActualizarUsuario(usu);
        }
        public static void EliminarUsuario(Usuario usu)
        {
            UsuarioData.EliminarUsuario(usu);
        }
        public static List<Usuario> PopularUsuarios()
        {
            return UsuarioData.PopularUsuarios();
        }
        public static Usuario ObtenerUsuarioxId(int idUsuario)
        {
            return UsuarioData.ObtenerUsuarioxId(idUsuario);
        }
        public static Usuario Login(string usuario, string password)
        {
            return UsuarioData.Login(usuario, password);  
        }

    }
}
