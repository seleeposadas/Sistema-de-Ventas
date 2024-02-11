using Sistema_de_Ventas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections;

namespace PE2_acceso_datos.Acceso_Datos
{
    public static class UsuarioData
    {
        private static readonly string connectionstring = @"Data Source=DESKTOP-O0PV3PQ;Initial Catalog=SistemaGestion;Integrated Security=True;Trust Server Certificate=True";

        public static void RegistrarUsuario(Usuario usu)
        {
            string consulta = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                "VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail) ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand( consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar){ Value = usu.Nombre});
                        com.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usu.Apellido });
                        com.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usu.NombreUsuario });
                        com.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usu.Contrasenia });
                        com.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usu.Mail });
                        com.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void ActualizarUsuario(Usuario usu)
        {
            string consulta = "UPDATE Usuario SET " +
                "Nombre = @Nombre, " +
                "Apellido = @Apellido, " +
                "NombreUsuario = @NombreUsuario, " +
                "Contraseña = @Contraseña, " +
                "Mail = @Mail " +
                "WHERE IdUsuario = @IdUsuario";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usu.Nombre });
                        com.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usu.Apellido });
                        com.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usu.NombreUsuario });
                        com.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usu.Contrasenia });
                        com.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usu.Mail });
                        com.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = usu.IdUsuario });
                        com.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void EliminarUsuario(Usuario usu)
        {
            string consulta = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = usu.IdUsuario });
                        com.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static List<Usuario> PopularUsuarios() 
        { 
            List<Usuario> lstUsu = new List<Usuario>();
            string consulta = "SELECT u.idUsuario, " +
                "u.Nombre, " +
                "u.Apellido, " +
                "u.NombreUsuario, " +
                "u.Contraseña, " +
                "u.Mail " +
                "FROM usuario u";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                       using(SqlDataReader dr = com.ExecuteReader())
                        {
                            if (dr.HasRows) 
                            {
                                while (dr.Read()) 
                                {
                                    Usuario usu = new Usuario();

                                    usu.IdUsuario = dr["IdUsuario"] is DBNull ? 0 : Convert.ToInt32(dr["IdUsuario"]);
                                    usu.Nombre = dr["Nombre"] is DBNull ? "" : dr["Nombre"].ToString();
                                    usu.Apellido = dr["Apellido"] is DBNull ? "" : dr["Apellido"].ToString();
                                    usu.NombreUsuario = dr["NombreUsuario"] is DBNull ? "" : dr["NombreUsuario"].ToString();
                                    usu.Contrasenia = dr["Contraseña"] is DBNull ? "" : dr["Contraseña"].ToString();
                                    usu.Mail = dr["Mail"] is DBNull ? "" : dr["Mail"].ToString();

                                    lstUsu.Add(usu);
                                }
                            }
                            dr.Close();
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return lstUsu; 
        }

        public static Usuario ObtenerUsuarioxId(int idUsuario)
        {
            Usuario usu = new Usuario();

            string consulta = "SELECT IdUsuario, " +
                                     "Nombre, " +
                                     "Apellido, " +
                                     "NombreUsuario, " +
                                     "Contraseña, " +
                                     "Mail " +
                               "FROM Usuario " +
                              "WHERE IdUsuario = @IdUsuario";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(consulta, con))
                    {
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = idUsuario });
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    usu.IdUsuario = dr["IdUsuario"] is DBNull ? 0 : Convert.ToInt32(dr["IdUsuario"]);
                                    usu.Nombre = dr["Nombre"] is DBNull ? "" : dr["Nombre"].ToString();
                                    usu.Apellido = dr["Apellido"] is DBNull ? "" : dr["Apellido"].ToString();
                                    usu.NombreUsuario = dr["NombreUsuario"] is DBNull ? "" : dr["NombreUsuario"].ToString();
                                    usu.Contrasenia = dr["Contraseña"] is DBNull ? "" : dr["Contraseña"].ToString();
                                    usu.Mail = dr["Mail"] is DBNull ? "" : dr["Mail"].ToString();
                                }
                            }
                            dr.Close();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return usu;
        }



        public static Usuario Login(string usuario, string password)
        {
            Usuario usu = new Usuario();

            string _sente = "SELECT IdUsuario, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario where NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(_sente, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = password });

                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    usu.IdUsuario = dr["IdUsuario"] is DBNull ? 0 : Convert.ToInt32(dr["IdUsuario"]);
                                    usu.Nombre = dr["Nombre"] is DBNull ? "" : dr["Nombre"].ToString();
                                    usu.Apellido = dr["Apellido"] is DBNull ? "" : dr["Apellido"].ToString();
                                    usu.NombreUsuario = dr["NombreUsuario"] is DBNull ? "" : dr["NombreUsuario"].ToString();
                                    usu.Contrasenia = dr["Contraseña"] is DBNull ? "" : dr["Contraseña"].ToString();
                                    usu.Mail = dr["Mail"] is DBNull ? "" : dr["Mail"].ToString();

                                }
                            }
                            dr.Close();
                        }
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return usu;

        }



    }
}
