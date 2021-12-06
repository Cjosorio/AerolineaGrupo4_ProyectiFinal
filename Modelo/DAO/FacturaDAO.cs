using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AerolineaGrupo4.Modelo.Entidades;

namespace AerolineaGrupo4.Modelo.DAO
{
    public class FacturaDAO : Conexion
    {

        SqlCommand comando = new SqlCommand();


        public bool InsertarNuevaFactura(Factura factura)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO FACTURA ");
                sql.Append(" VALUES (@ID_USUARIO, @ID_BOLETO,@PRECIO,@CANTIDAD,@ISV,@SUBTOTAL,@total); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = factura.IdUsuario;
                comando.Parameters.Add("@ID_BOLETO", SqlDbType.Int).Value = factura.IdBoleto;
                comando.Parameters.Add("@PRECIO", SqlDbType.Decimal).Value = factura.Precio;
                comando.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = factura.Cantidad;
                comando.Parameters.Add("@ISV", SqlDbType.Decimal).Value = factura.ISV;
                comando.Parameters.Add("@SUBTOTAL", SqlDbType.Decimal).Value = factura.SubTotal;
                comando.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.Total;

                inserto = true;
                MiConexion.Close();


            }
            catch (Exception ex)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetFactura()
        {
            DataTable dta = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM FACTURA");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                SqlDataReader dr = comando.ExecuteReader();
                dta.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dta;
        }
        public bool ActualizarFactura(Factura factura)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE FACTURA  ");
                sql.Append(" SET ID_USUARIO= @ID_USUARIO, ID_BOLETO=@ID_BOLETO, PRECIO=@PRECIO,CANTIDAD=@CANTIDAD,ISV=@ISV, SUBTOTAL=@SUBTOTAL,TOTAL=@total ");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = factura.IdUsuario;
                comando.Parameters.Add("@ID_BOLETO", SqlDbType.Int).Value = factura.IdBoleto;
                comando.Parameters.Add("@PRECIO", SqlDbType.Decimal).Value = factura.Precio;
                comando.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = factura.Cantidad;
                comando.Parameters.Add("@ISV", SqlDbType.Decimal).Value = factura.ISV;
                comando.Parameters.Add("@SUBTOTAL", SqlDbType.Decimal).Value = factura.SubTotal;
                comando.Parameters.Add("@total", SqlDbType.Decimal).Value = factura.Total;

                comando.ExecuteNonQuery();
                actualizo = true;
                MiConexion.Close();


            }
            catch (Exception ex)
            {
                actualizo = false;

            }
            return actualizo;

        }


        public bool EliminarFactura(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM FACTURA ");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                elimino = true;
                MiConexion.Close();


            }
            catch (Exception)
            {
                elimino = false;

            }
            return elimino;

        }




    } 
    } 



