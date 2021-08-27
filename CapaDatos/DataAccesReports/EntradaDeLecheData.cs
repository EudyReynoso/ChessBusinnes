using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.DataAccesReports
{
    public class EntradaDeLecheData: ConexionData
    {
        public DataTable EntradaDelecheByFecha(DateTime desde, DateTime hasta)
        {

            SqlCommand command = new SqlCommand("dbo.SP_GetEntradasByFecha", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@Desde", SqlDbType.Date).Value = desde;
            command.Parameters.AddWithValue("@Hasta", SqlDbType.Date).Value = hasta;
           
            DataTable dataTable = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            dataReader.Dispose();

            CerrarConexion();

            return dataTable;
        }
        public DataTable EntradaDelecheListado()
        {

            SqlCommand command = new SqlCommand("dbo.SP_GetALLEntradas", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };

            DataTable dataTable = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            dataReader.Close();
            dataReader.Dispose();
            CerrarConexion();

            return dataTable;
        }
    }
}
