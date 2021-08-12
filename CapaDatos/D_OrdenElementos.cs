using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_OrdenElementos: ConexionData
    {

        public DataTable ListaOrdenesElementos()
        {
            DataTable Listado = new DataTable();

            SqlCommand query = new SqlCommand("dbo.SP_SelectAllOrdenesElementos", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = query.ExecuteReader();

            Listado.Load(dataReader);
            dataReader.Close();
            CerrarConexion();

            return Listado;
        }
    }
}
