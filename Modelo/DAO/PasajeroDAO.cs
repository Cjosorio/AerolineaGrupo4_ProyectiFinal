using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AerolineaGrupo4.Modelo.Entidades;

namespace AerolineaGrupo4.Modelo.DAO
{
  public   class PasajeroDAO:Conexion
    {

        SqlCommand comando = new SqlCommand();


        //insertar un nuevo
        public bool InsertarNuevoPasajero(Pasajero pasajero)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO PASAJERO ");
                sql.Append(" VALUES (@Nombre, @Apellidos, @Edad, @Genero, @Nacionalidad, @Pasaporte, @Telefono, @Email); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = pasajero.Nombre;
                comando.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = pasajero.Apellidos;
                comando.Parameters.Add("@Edad", SqlDbType.NVarChar, 50).Value = pasajero.Edad;
                comando.Parameters.Add("@Genero", SqlDbType.NVarChar, 50).Value = pasajero.Genero;
                comando.Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = pasajero.Nacionalidad;
                comando.Parameters.Add("@Pasaporte", SqlDbType.NVarChar, 50).Value = pasajero.Pasaporte;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = pasajero.Telefono;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = pasajero.Email;
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

        ///consultar todos los usuarios 
        public DataTable GetPasajeros()
        {
            DataTable dta = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM PASAJERO ");

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

        //actualizar 
        public bool ActualizarPasajero(Pasajero pasajero)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE PASAJERO ");
                sql.Append(" SET NOMBRE = @Nombre, @Apellidos, @Edad, @Genero, @Nacionalidad, @Pasaporte, @Telefono, @Email ");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = pasajero.Nombre;
                comando.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = pasajero.Apellidos;
                comando.Parameters.Add("@Edad", SqlDbType.NVarChar, 50).Value = pasajero.Edad;
                comando.Parameters.Add("@Genero", SqlDbType.NVarChar, 50).Value = pasajero.Genero;
                comando.Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = pasajero.Nacionalidad;
                comando.Parameters.Add("@Pasaporte", SqlDbType.NVarChar, 50).Value = pasajero.Pasaporte;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = pasajero.Telefono;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = pasajero.Email;
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

        //eliminar 
        public bool EliminarPasajero(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM PASAJERO ");
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
