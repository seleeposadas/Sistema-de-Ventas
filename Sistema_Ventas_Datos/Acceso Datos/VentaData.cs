using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Ventas.Entidades;

namespace PE2_acceso_datos.Acceso_Datos
{
    public class VentaData
    {
        private static readonly string connectionstring = @"Data Source=DESKTOP-O0PV3PQ;Initial Catalog=SistemaGestion;Integrated Security=True;Trust Server Certificate=True";

        public static void RegistrarVenta(Venta ven)
        {
            string consulta = "INSERT INTO Venta (Comentarios, IdUsuario) " +
                "VALUES (@Comentarios, @IdUsuario) ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = ven.Comentarios });
                        com.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = ven.IdUsuario });
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


        public static void ActualizarVenta(Venta ven)
        {
            string consulta = "UPDATE Venta SET " +
                "Comentarios = @Comentarios, " +
                "IdUsuario = @IdUsuario " +
                "WHERE IdVenta = @IdVenta ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = ven.IdVenta });
                        com.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = ven.Comentarios });
                        com.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = ven.IdUsuario });
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


        public static void EliminarVenta(Venta ven)
        {
            string consulta = "DELETE FROM Venta WHERE IdVenta = @IdVenta ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = ven.IdVenta });
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


        public static List<Venta> PopularVenta()
        {
            List<Venta> lstVenta = new List<Venta>();
            string consulta = "SELECT v.IdVenta, " +
                                     "v.Comentarios, " +
                                     "v.IdUsuario, " +
                                     "u.Nombre + ' ' + u.Apellido AS nombre " +
                                "FROM Venta v JOIN Usuario u ON v.IdUsuario = u.IdUsuario ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader dr = com.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Venta ven = new Venta();

                                    ven.IdVenta = dr["IdVenta"] is DBNull ? 0 : Convert.ToInt32(dr["IdVenta"]);
                                    ven.Comentarios = dr["Comentarios"] is DBNull ? "" : dr["Comentarios"].ToString();
                                    ven.IdUsuario = dr["IdUsuario"] is DBNull ? 0 : Convert.ToInt32(dr["IdUsuario"]);
                                    ven.NombreUsuario = dr["nombre"] is DBNull ? "" : dr["nombre"].ToString();

                                    lstVenta.Add(ven);
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

            return lstVenta;
        }

        public static Venta ObtenerVentaxId(int IdVenta)
        {
            Venta ven = new Venta();

            string consulta = "SELECT IdVenta, " +
                                     "Comentarios, " +
                                     "IdUsuario " +
                                "FROM Venta " +
                               "WHERE IdVenta = @IdVenta ";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(consulta, con))
                    {
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = IdVenta });
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    ven.IdVenta = dr["IdVenta"] is DBNull ? 0 : Convert.ToInt32(dr["IdVenta"]);
                                    ven.Comentarios = dr["Comentarios"] is DBNull ? "" : dr["Comentarios"].ToString();
                                    ven.IdUsuario = dr["IdUsuario"] is DBNull ? 0 : Convert.ToInt32(dr["IdUsuario"]);
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
            return ven;
        }
    }
}
