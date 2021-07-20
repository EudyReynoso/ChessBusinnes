using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Puestos
    {
        private ConexionData conexion = new ConexionData();
        public DataTable ListaPuesto()
        {
            DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("SP_ListaPuestos", conexion.AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);
            dataReader.Close();
            conexion.CerrarConexion();
            return Listado;
        }
    }
}
