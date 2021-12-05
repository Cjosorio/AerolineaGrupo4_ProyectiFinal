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
 public   class BoletoDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();

        //Codigo para insertar un nuevo usuario en la base de datos 

        public bool InsertarNuevoBoleto(Boleto user)

        {
            bool inserto = false;
            try

            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO BOLETO ");
                sql.Append(" VALUES (@IdPasajero, @Clase,@Asiento,@FechaVuelo,@Precio); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdPasajero", SqlDbType.Int).Value = user.IDPasajero;
                comando.Parameters.Add("@Clase", SqlDbType.NVarChar, 50).Value = user.Clase;
                comando.Parameters.Add("@Asiento", SqlDbType.NVarChar, 50).Value = user.Asiento;
                comando.Parameters.Add("@FechaVuelo", SqlDbType.DateTime).Value = user.FechaVuelo;
                comando.Parameters.Add("@Precio", SqlDbType.NVarChar, 50).Value = user.Precio;
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
        public DataTable GetBoleto()

        {
            DataTable dta = new DataTable();
            try

            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM BOLETO ");
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
        public bool ActualizarBoleto(Boleto user)

        {
            bool actualizo = false;
            try

            {
                StringBuilder sql = new StringBuilder();

                sql.Append(" UPDATE BOLETO ");
                sql.Append(" SET ID_PASAJERO = @IdPasajero, CLASE= @Clase, ASIENTO= @Asiento,FECHA_VUELO=@FechaVuelo,PRECIO=@Precio");
                sql.Append("WHERE ID = @Id; ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@IdPasajero", SqlDbType.Int).Value = user.IDPasajero;
                comando.Parameters.Add("@Clase", SqlDbType.NVarChar, 50).Value = user.Clase;
                comando.Parameters.Add("@Asiento", SqlDbType.NVarChar, 50).Value = user.Asiento;
                comando.Parameters.Add("@FechaVuelo", SqlDbType.DateTime).Value = user.FechaVuelo;
                comando.Parameters.Add("@Precio", SqlDbType.NVarChar, 50).Value = user.Precio;
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
        public bool EliminarBoleto(int id)

        {
            bool elimino = false;
            try

            {
                StringBuilder sql = new StringBuilder();

                sql.Append(" DELETE FROM BOLETO ");

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
