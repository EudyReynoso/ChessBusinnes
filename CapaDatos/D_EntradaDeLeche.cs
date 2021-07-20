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
    public class D_EntradaDeLeche
    {
        private ConexionData Conexion = new ConexionData();

        public DataTable ListaEntradaDeLeche()
        {
            DataTable Listado = new DataTable();

            SqlCommand SqlQuery = new SqlCommand("SP_SeleccionarAllEntradas", Conexion.AbrirConexion());
            SqlQuery.CommandType = CommandType.StoredProcedure;

            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);

            dataReader.Close();
            Conexion.CerrarConexion();
            return Listado;
        }
        public void InsertarEntradaDeLeche(E_EntradaDeLeche entrada)
        {
            SqlCommand command = new SqlCommand("SP_InsertarEntrada", Conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdSuplidor", entrada.Idsuplidor);
            command.Parameters.AddWithValue("@IdRecolector", entrada.Recolector);
            command.Parameters.AddWithValue("@Cantidad", entrada.Cantidadbotellas);
            command.Parameters.AddWithValue("@IdEstado", entrada.Idestado);
            command.Parameters.AddWithValue("@Fecha", entrada.Fechaentrada);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            Conexion.CerrarConexion();
        }

        public void ActualizarEntrada(E_EntradaDeLeche entrada)
        {
            SqlCommand command = new SqlCommand("SP_EditarEntrada", Conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdEntrada", entrada.Identrada);
            command.Parameters.AddWithValue("@IdSuplidor", entrada.Idsuplidor);
            command.Parameters.AddWithValue("@IdRcolector", entrada.Recolector);
            command.Parameters.AddWithValue("@CantidadEnBotellas", entrada.Cantidadbotellas);
            command.Parameters.AddWithValue("@IdEstado", entrada.Idestado);
            command.Parameters.AddWithValue("@Fecha", entrada.Fechaentrada);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            Conexion.CerrarConexion();
        }

        public void EliminarEntradaDeLEche( E_EntradaDeLeche e_Entrada)
        {
            SqlCommand command = new SqlCommand("SP_EliminarEntrada", Conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdEntrada", e_Entrada.Identrada);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

            Conexion.CerrarConexion();
        }
    }
}
