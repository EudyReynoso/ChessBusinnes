using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Ordenes: ConexionData
    {
        public DataTable ListaOrdenesVentas()
        {
            DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("dbo.SP_GetVentasADetalle", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);
            dataReader.Close();
            CerrarConexion();
            return Listado;
        }
        public DataTable BuscarFactura( string valor)
        {
            DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("dbo.SP_BuscarVentas", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            
            SqlQuery.Parameters.AddWithValue("@Codigo", valor);
            
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);
            dataReader.Close();
            CerrarConexion();
            return Listado;
        }
        public void InsertarOrden(E_OrdenElementos ordenElementos)
        {
            SqlCommand Command = new SqlCommand("dbo.SP_InsertOrdenElemetos", AbrirConexion());
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@ProductoId", ordenElementos.Idproducto);
            Command.Parameters.AddWithValue("@IdOrden", ordenElementos.IdOrden);
            Command.Parameters.AddWithValue("@Cantidad", ordenElementos.Cantidad);

            Command.ExecuteNonQuery();
            Command.Parameters.Clear();

            CerrarConexion();
        }
        public void InsertarOrdenFecha(E_Orden orden)
        {
            SqlCommand Command = new SqlCommand("dbo.SP_InsertOrdendate", AbrirConexion());
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@Fecha", orden.Fecha);
            Command.Parameters.AddWithValue("@Descuento", orden.Descuento);
            Command.Parameters.AddWithValue("@SubTotal", orden.SubTotal);
            Command.Parameters.AddWithValue("@TotalAlpago", orden.Montototal);
            
            Command.ExecuteNonQuery();
            Command.Parameters.Clear();

            CerrarConexion();
        }

        public int GetOrdenId()
        {
            SqlCommand Command = new SqlCommand("dbo.SP_GetILastdOrden", AbrirConexion());
            Command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter("@IdOrden", 0);
            parameter.Direction = ParameterDirection.Output;

            Command.Parameters.Add(parameter);
            Command.ExecuteNonQuery();

            int IDOrden = Convert.ToInt32(Command.Parameters["@IdOrden"].Value);

            return IDOrden;
        }

        public int  GetOrdenElemntosId()
        {
            SqlCommand Command = new SqlCommand("dbo.SP_GetLastIdOrdenElementos", AbrirConexion());
            Command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter("@IdOrdenElemento", 0);
            parameter.Direction = ParameterDirection.Output;

            Command.Parameters.Add(parameter);
            Command.ExecuteNonQuery();

            int IDOrden = Convert.ToInt32(Command.Parameters["@IdOrdenElemento"].Value);

            return IDOrden;
        }
    }
}
