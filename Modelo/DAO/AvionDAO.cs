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
   public  class AvionDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoAvion(Avion avion)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO AVION ");
                sql.Append(" VALUES (@Id, @Modelo, @Capacidad, @Estado, @Siglas); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = avion.Id;
                comando.Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = avion.Modeloavion;
                comando.Parameters.Add("@Capacidad", SqlDbType.NVarChar,50).Value = avion.Capacidad;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 50).Value = avion.Estado;
                comando.Parameters.Add("@Siglas", SqlDbType.NVarChar, 50).Value = avion.Siglas;

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

        public DataTable GetAvion()
        {
            DataTable dta = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM AVION ");

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
        public bool ActualizarAvion(Avion avion)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE AVION ");
                sql.Append(" SET MODELO = @Modelo, CAPACIDAD = @Capacidad, ESTADO = @Estado, SIGLAS = @Siglas");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = avion.Id;
                comando.Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = avion.Modeloavion;
                comando.Parameters.Add("@Capacidad", SqlDbType.NVarChar, 50).Value = avion.Capacidad;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 50).Value = avion.Estado;
                comando.Parameters.Add("@Siglas", SqlDbType.NVarChar, 50).Value = avion.Siglas;


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
        public bool EliminarAvion(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE AVION ");
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
