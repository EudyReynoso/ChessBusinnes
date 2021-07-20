using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaDatos
{
    public class D_EstadosDeLeche
    {
        ConexionData Conexion = new ConexionData();

        public DataTable ListaDeEstados()
        {
            DataTable listado = new DataTable();

            SqlCommand SqlQuery = new SqlCommand("SP_ListaEstados", Conexion.AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            listado.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return listado;
        }
    }
}
