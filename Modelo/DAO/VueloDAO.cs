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
  public  class VueloDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();



        public bool InsertarNuevoVuelo(Vuelo vuelo)

        {

            bool inserto = false;

            try

            {

                StringBuilder sql = new StringBuilder();

                sql.Append(" INSERT INTO VUELO ");

                sql.Append(" VALUES (@Id, @Hora_Salida, @Hora_Llegada, @Origen, @Destino); ");



                comando.Connection = MiConexion;

                MiConexion.Open();

                comando.CommandType = CommandType.Text;

                comando.CommandText = sql.ToString();



                comando.Parameters.Add("@Id", SqlDbType.Int).Value = vuelo.Id;

                comando.Parameters.Add("@Hora_Salida", SqlDbType.NVarChar, 50).Value = vuelo.Hora_Salidad;

                comando.Parameters.Add("@Hora_Llegada", SqlDbType.NVarChar,50).Value = vuelo.Hora_Llegada;

                comando.Parameters.Add("@Origen", SqlDbType.NVarChar, 50).Value = vuelo.Origen;

                comando.Parameters.Add("@Destino", SqlDbType.NVarChar, 50).Value = vuelo.Destino;



                comando.ExecuteNonQuery();

                inserto = true;

                MiConexion.Close();





            }

            catch (Exception)

            {

                inserto = false;

            }

            return inserto;

        }



        public DataTable GetVuelo()

        {

            DataTable dta = new DataTable();

            try

            {

                StringBuilder sql = new StringBuilder();

                sql.Append(" SELECT * FROM VUELO ");



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

        public bool ActualizarVuelo(Vuelo vuelo)

        {

            bool actualizo = false;

            try

            {

                StringBuilder sql = new StringBuilder();

                sql.Append(" UPDATE VUELO ");

                sql.Append(" SET HORA_SALIDA = @Hora_Salida, HORA_LLEGADA = @Hora_Llegada, ORIGEN = @Origen, DESTINO = @Destino");

                sql.Append("WHERE ID = @Id; ");



                comando.Connection = MiConexion;

                MiConexion.Open();

                comando.CommandType = CommandType.Text;

                comando.CommandText = sql.ToString();



                comando.Parameters.Add("@Id", SqlDbType.Int).Value = vuelo.Id;

                comando.Parameters.Add("@Hora_Salida", SqlDbType.NVarChar, 50).Value = vuelo.Hora_Salidad;

                comando.Parameters.Add("@Hora_Llegada", SqlDbType.Int).Value = vuelo.Hora_Llegada;

                comando.Parameters.Add("@Origen", SqlDbType.NVarChar, 50).Value = vuelo.Origen;

                comando.Parameters.Add("@Destino", SqlDbType.NVarChar, 50).Value = vuelo.Destino;





                comando.ExecuteNonQuery();

                actualizo = true;

                MiConexion.Close();





            }

            catch (Exception)

            {

                actualizo = false;



            }

            return actualizo;



        }

        public bool EliminarVuelo(int id)

        {



            bool elimino = false;

            try

            {

                StringBuilder sql = new StringBuilder();

                sql.Append(" DELETE VUELO ");

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
