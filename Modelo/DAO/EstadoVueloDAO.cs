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
 public   class EstadoVueloDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();
        //Codigo para insertar un nuevo usuario en la base de datos
        public bool InsertarNuevoEstadoVuelo(EstadoVuelo user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADO_VUELO ");
                sql.Append(" VALUES (@Disponible, @Retrasado,  @Cancelado); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Disponible", SqlDbType.Bit).Value = user.Disponible;
                comando.Parameters.Add("@Retrasado", SqlDbType.Bit).Value = user.Retrasado;
                comando.Parameters.Add("@Cancelado", SqlDbType.Bit).Value = user.Cancelado;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();


            }
            catch (Exception ex)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetEstadoVuelo()
        {
            DataTable dta = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADO_VUELO ");

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

        public bool ActualizarEstadoVuelo(EstadoVuelo user)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ESTADO_VUELO ");
                sql.Append(" SET DISPONIBLE = @Disponible, RETRASADO = @Retrasado, CANCELADO = @Cancelado ");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@Disponible", SqlDbType.Bit).Value = user.Disponible;
                comando.Parameters.Add("@Retrasado", SqlDbType.Bit).Value = user.Retrasado;
                comando.Parameters.Add("@Cancelado", SqlDbType.Bit).Value = user.Cancelado;
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

        public bool EliminarEstadoVuelo(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM ESTADO_VUELO ");
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
