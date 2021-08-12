using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using MaterialSkin.Controls;

namespace CapaDatos
{
    public class D_Suplidor: ConexionData
    {
        public DataTable ListaSuplidores()
        {
            DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("SP_SeleccionarTodosLosSuplidores", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);
            dataReader.Close();
            CerrarConexion();
            return Listado;
        }
        public DataTable ValoreMienbrosComoSuplidores()
        {
            DataTable Valores = new DataTable();
            SqlCommand command = new SqlCommand("SP_ValoreMienbrosComoSuplidores", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = command.ExecuteReader();
            Valores.Load(dataReader);
            dataReader.Close();
            CerrarConexion();

            return Valores;
        }
        public void InsertarSuplidor(E_Suplidor suplidor)
        {
            SqlCommand command = new SqlCommand("InsertarSuplidor", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Nombre", suplidor.Nombre);
            command.Parameters.AddWithValue("@Apellido", suplidor.Apellido);
            command.Parameters.AddWithValue("@Direccion", suplidor.Direccion);
            command.Parameters.AddWithValue("@NumeroTel", suplidor.NumeroTel);


            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        public void ActualizarSuplidor(E_Suplidor suplidor)
        {
            SqlCommand command = new SqlCommand("ActualizarSuplidor", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdSuplidor", suplidor.Idsuplidor);
            command.Parameters.AddWithValue("@Apellidos", suplidor.Apellido);
            command.Parameters.AddWithValue("@Nombre", suplidor.Nombre);
            command.Parameters.AddWithValue("@Direccion", suplidor.Direccion);
            command.Parameters.AddWithValue("@NumeroTel", suplidor.NumeroTel);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        public void ElimininarSuplidor( E_Suplidor suplidor)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_EliminarSuplidor", AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdSuplidor", suplidor.Idsuplidor);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                CerrarConexion();
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("No se pueden eliminar porque este suplidor, hay entradas de leche con sus datos");
            }
        }
    }
}
