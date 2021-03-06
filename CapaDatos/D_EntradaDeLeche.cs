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
    public class D_EntradaDeLeche: ConexionData
    {

        public DataTable ListaEntradaDeLeche()
        {
            DataTable Listado = new DataTable();

            SqlCommand SqlQuery = new SqlCommand("SP_SeleccionarAllEntradas", AbrirConexion());
            SqlQuery.CommandType = CommandType.StoredProcedure;

            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);

            dataReader.Close();
            CerrarConexion();
            return Listado;
        }
        public void InsertarEntradaDeLeche(E_EntradaDeLeche entrada)
        {
            SqlCommand command = new SqlCommand("SP_InsertarEntrada", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdSuplidor", entrada.Idsuplidor);
            command.Parameters.AddWithValue("@IdRecolector", entrada.Recolector);
            command.Parameters.AddWithValue("@Cantidad", entrada.Cantidadbotellas);
            command.Parameters.AddWithValue("@PrecioBotella", entrada.PrecioPorbotella);
            command.Parameters.AddWithValue("@IdEstado", entrada.Idestado);
            command.Parameters.AddWithValue("@Fecha", entrada.Fechaentrada);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }

        public void ActualizarEntrada(E_EntradaDeLeche entrada)
        {
            SqlCommand command = new SqlCommand("SP_EditarEntrada", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdEntrada", entrada.Identrada);
            command.Parameters.AddWithValue("@IdSuplidor", entrada.Idsuplidor);
            command.Parameters.AddWithValue("@IdRcolector", entrada.Recolector);
            command.Parameters.AddWithValue("@CantidadEnBotellas", entrada.Cantidadbotellas);
            command.Parameters.AddWithValue("@PrecioBotella", entrada.PrecioPorbotella);
            command.Parameters.AddWithValue("@IdEstado", entrada.Idestado);
            command.Parameters.AddWithValue("@Fecha", entrada.Fechaentrada);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }

        public void EliminarEntradaDeLEche( E_EntradaDeLeche e_Entrada)
        {
            SqlCommand command = new SqlCommand("SP_EliminarEntrada", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdEntrada", e_Entrada.Identrada);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

            CerrarConexion();
        }
        public DataTable BuscarEntradasDeLeche(string valor)
        {

            SqlCommand query = new SqlCommand("SP_BuscarEntradasDeLechebySuplidor", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            query.Parameters.AddWithValue("@Suplidor", valor);
            SqlDataReader dataReader = query.ExecuteReader();

            DataTable lista = new DataTable();

            lista.Load(dataReader);
            dataReader.Close();
            CerrarConexion();

            return lista;
        }
    }
}
