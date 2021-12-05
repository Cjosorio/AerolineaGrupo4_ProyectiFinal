using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace AerolineaGrupo4.Modelo.DAO
{
  public   class Conexion
    {
        protected SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ProyectoConexion"].ConnectionString);
    }
}
