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
    public static class ProductoVendidoData
    {
        private static readonly string connectionstring = @"Data Source=DESKTOP-O0PV3PQ;Initial Catalog=SistemaGestion;Integrated Security=True;Trust Server Certificate=True";

        public static void RegistrarProductoVendido(ProductoVendido prod)
        {
            string consulta = "INSERT INTO ProductoVendido (IdProductoVendido, Stock, IdProducto, IdVenta) " +
                "VALUES (@IdProductoVendido, @Stock, @IdProducto, @IdVenta) ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdProductoVendido", SqlDbType.BigInt) { Value = prod.IdProductoVendido });
                        com.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = prod.Stock });
                        com.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = prod.IdProducto });
                        com.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = prod.IdVenta });
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


        public static void ActualizarProductoVendido(ProductoVendido prod)
        {
            string consulta = "UPDATE ProductoVendido SET " +
                "Stock = @Stock, " +
                "IdProducto = @IdProducto, " +
                "IdVenta = @IdVenta, " +
                "WHERE IdProductoVendido = @IdProductoVendido ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdProductoVendido", SqlDbType.BigInt) { Value = prod.IdProductoVendido });
                        com.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = prod.Stock });
                        com.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = prod.IdProducto });
                        com.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = prod.IdVenta });
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


        public static void EliminarProducto(ProductoVendido prod)
        {
            string consulta = "DELETE FROM ProductoVendido WHERE IdProductoVendido = @IdProductoVendido ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();
                    using (SqlCommand com = new SqlCommand(consulta, conexion))
                    {
                        com.Parameters.Add(new SqlParameter("IdProductoVendido", SqlDbType.BigInt) { Value = prod.IdProductoVendido });
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


        public static List<ProductoVendido> PopularProductoVendido()
        {
            List<ProductoVendido> lstProdVendido = new List<ProductoVendido>();
            string consulta = "SELECT IdProductoVendido, " +
                                     "Stock, " +
                                     "IdProducto, " +
                                     "IdVenta, " +
                                "FROM ProductoVendido ";
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
                                    ProductoVendido prod = new ProductoVendido();

                                    prod.IdProductoVendido = dr["IdProductoVendido"] is DBNull ? 0 : Convert.ToInt32(dr["IdProductoVendido"]);
                                    prod.Stock = dr["Stock"] is DBNull ? 0 : Convert.ToInt32(dr["Stock"]);
                                    prod.IdProducto = dr["IdProducto"] is DBNull ? 0 : Convert.ToInt32(dr["IdProducto"]);
                                    prod.IdVenta = dr["IdVenta"] is DBNull ? 0 : Convert.ToInt32(dr["IdVenta"]);

                                    lstProdVendido.Add(prod);
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

            return lstProdVendido;
        }

        public static ProductoVendido ObtenerProductoVendioxId(int IdProductoVendido)
        {
            ProductoVendido prod = new ProductoVendido();

            string consulta = "SELECT IdProductoVendido, " +
                                     "Stock, " +
                                     "IdProducto, " +
                                     "IdVenta, " +
                                "FROM ProductoVendido " +
                               "WHERE IdProductoVendido = @IdProductoVendido ";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(consulta, con))
                    {
                        command.Parameters.Add(new SqlParameter("IdProductoVendido", SqlDbType.Int) { Value = IdProductoVendido });
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    prod.IdProductoVendido = dr["IdProductoVendido"] is DBNull ? 0 : Convert.ToInt32(dr["IdProductoVendido"]);
                                    prod.Stock = dr["Stock"] is DBNull ? 0 : Convert.ToInt32(dr["Stock"]);
                                    prod.IdProducto = dr["IdProducto"] is DBNull ? 0 : Convert.ToInt32(dr["IdProducto"]);
                                    prod.IdVenta = dr["IdVenta"] is DBNull ? 0 : Convert.ToInt32(dr["IdVenta"]);
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
