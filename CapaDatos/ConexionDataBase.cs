using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class ConexionData
    {
        private SqlConnection ConexionDB =
            new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringChessDB"].ConnectionString);
        
        public SqlConnection AbrirConexion()
        {
            if(ConexionDB.State == ConnectionState.Closed)
            {
                ConexionDB.Open();
            }
            return ConexionDB;
        }

        public SqlConnection CerrarConexion()
        {
            if (ConexionDB.State == ConnectionState.Open)
            {
                ConexionDB.Close();
            }
            return ConexionDB;
        }
    }
}
