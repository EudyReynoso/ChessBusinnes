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
    public class D_Suplidor
    {
        private ConexionData Conexion = new ConexionData();
        public DataTable ListaSuplidores()
        {
            DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("SP_SeleccionarTodosLosSuplidores", Conexion.AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Listado;
        }
        public void InsertarSuplidor(E_Suplidor suplidor)
        {
            SqlCommand command = new SqlCommand("InsertarSuplidor", Conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Nombre", suplidor.Nombre);
            command.Parameters.AddWithValue("@Apellido", suplidor.Apellido);
            command.Parameters.AddWithValue("@Direccion", suplidor.Direccion);
            command.Parameters.AddWithValue("@NumeroTel", suplidor.NumeroTel);


            command.ExecuteNonQuery();
            command.Parameters.Clear();
            Conexion.CerrarConexion();
        }
        public void ActualizarSuplidor(E_Suplidor suplidor)
        {
            SqlCommand command = new SqlCommand("ActualizarSuplidor", Conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdSuplidor", suplidor.Idsuplidor);
            command.Parameters.AddWithValue("@Apellidos", suplidor.Apellido);
            command.Parameters.AddWithValue("@Nombre", suplidor.Nombre);
            command.Parameters.AddWithValue("@Direccion", suplidor.Direccion);
            command.Parameters.AddWithValue("@NumeroTel", suplidor.NumeroTel);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            Conexion.CerrarConexion();
        }
        public void ElimininarSuplidor( E_Suplidor suplidor)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_EliminarSuplidor", Conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdSuplidor", suplidor.Idsuplidor);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                Conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MaterialMessageBox.Show("No se pueden eliminar porque " +
                    "ya haces refrencia a este suplidor en una entrada de leche, " +
                    "se generan ecepciones en la relacion de los datos en SQL");
            }
        }
    }
}
