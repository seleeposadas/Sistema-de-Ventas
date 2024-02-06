using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using Sistema_de_Ventas.Entidades;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections;

namespace PE2_acceso_datos.Acceso_Datos
{
    public static class ProductoData
    {
        private static readonly string connectionstring = @"Data Source=DESKTOP-O0PV3PQ;Initial Catalog=SistemaGestion;Integrated Security=True;Trust Server Certificate=True";

        public static void RegistrarProducto(Producto prod)
        {
            string consulta = "INSERT INTO Producto (IdProducto, Descripciones, Costo, PrecioVenta, Stock, IdUsuario) " +
                "VALUES (@IdProducto, @Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario) ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = prod.IdProducto });
                        com.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = prod.Descripcion});
                        com.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = prod.Costo });
                        com.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = prod.PrecioVenta });
                        com.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = prod.Stock });
                        com.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = prod.IdUsuario});
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


        public static void ActualizarProducto(Producto prod)
        {
            string consulta = "UPDATE Producto SET " +
                "Descripciones = @Descripciones, " +
                "Costo = @Costo, " +
                "PrecioVenta = @PrecioVenta, " +
                "Stock = @Stock, " +
                "IdUsuario = @IdUsuario " +
                "WHERE IdProducto = @IdProducto ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = prod.IdProducto });
                        com.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = prod.Descripcion });
                        com.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = prod.Costo }) ;
                        com.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = prod.PrecioVenta });
                        com.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = prod.Stock });
                        com.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = prod.IdUsuario });
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


        public static void EliminarProducto(Producto prod)
        {
            string consulta = "DELETE FROM Producto WHERE IdProducto = @IdProducto ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = prod.IdProducto });
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


        public static List<Producto> PopularProducto()
        {
            List<Producto> lstProd = new List<Producto>();
            string consulta = "SELECT IdProducto, " +
                                     "Descripciones, " +
                                     "Costo, " +
                                     "PrecioVenta, " +
                                     "Stock, " +
                                     "IdUsuario " +
                                "FROM producto ";
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
                                    Producto prod = new Producto();

                                    prod.IdProducto = dr["IdProducto"] is DBNull ? 0 : Convert.ToInt32(dr["IdProducto"]);
                                    prod.Descripcion = dr["Descripcion"] is DBNull ? "" : dr["Descripcion"].ToString();
                                    prod.Costo = dr["Costo"] is DBNull ? 0 : Convert.ToDecimal(dr["Costo"]);
                                    prod.PrecioVenta = dr["PrecioVenta"] is DBNull ? 0 : Convert.ToDecimal(dr["PrecioVenta"]);
                                    prod.Stock = dr["Stock"] is DBNull ? 0 : Convert.ToInt32(dr["Stock"]);
                                    prod.IdUsuario = dr["IdUsuario"] is DBNull ? 0 : Convert.ToInt32(dr["IdUsuario"]);

                                    lstProd.Add(prod);
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

            return lstProd;
        }

        public static Producto ObtenerProductoxId(int IdProducto)
        {
            Producto prod = new Producto();

            string consulta = "SELECT IdProducto, " +
                                     "Descripciones, " +
                                     "Costo, " +
                                     "PrecioVenta, " +
                                     "Stock, " +
                                     "IdUsuario " +
                               "FROM producto " +
                               "WHERE IdProducto = @IdProducto ";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(consulta, con))
                    {
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = IdProducto });
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    prod.IdProducto = dr["IdProducto"] is DBNull ? 0 : Convert.ToInt32(dr["IdProducto"]);
                                    prod.Descripcion = dr["Descripcion"] is DBNull ? "" : dr["Descripcion"].ToString();
                                    prod.Costo = dr["Costo"] is DBNull ? 0 : Convert.ToInt32(dr["Costo"]);
                                    prod.PrecioVenta = dr["PrecioVenta"] is DBNull ? 0 : Convert.ToDecimal(dr["PrecioVenta"]);
                                    prod.Stock = dr["Stock"] is DBNull ? 0 : Convert.ToInt32(dr["Stock"]);
                                    prod.IdUsuario = dr["IdUsuario"] is DBNull ? 0 : Convert.ToInt32(dr["IdUsuario"]);
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
            return prod;
        }


    }
}
