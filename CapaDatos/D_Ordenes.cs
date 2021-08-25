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
            Command.Parameters.AddWithValue("@Descuentod", orden.Descuento);
            Command.Parameters.AddWithValue("@SubTotal", orden.SubTotal);
            Command.Parameters.AddWithValue("@TotalAlpago", orden.Montototal);
            Command.ExecuteNonQuery();
            Command.Parameters.Clear();

            CerrarConexion();
        }
    }
}
