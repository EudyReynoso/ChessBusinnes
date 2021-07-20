using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CapaDatos
{
   public class D_Empleado
   {
        private ConexionData conexion = new ConexionData();
        
        #region Metodo Listar empleados

        public DataTable ListaEmpleados()  
        {
             DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("SP_SeleccionarTodosLosEmpleados", conexion.AbrirConexion());
            SqlQuery.CommandType = CommandType.StoredProcedure;
           
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
             Listado.Load(dataReader);
            
             dataReader.Close();
             conexion.CerrarConexion();
             return Listado;
        }
        #endregion
        #region Metodo insertar
        public void InsertarEmpleados(E_Empleado empleado)
        {
            SqlCommand command = new SqlCommand("InsertEmpleado", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
            command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
            command.Parameters.AddWithValue("@Puesto", empleado.Puesto);
            command.Parameters.AddWithValue("@Departmento", empleado.Departamento);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }
        #endregion
        #region Metodo Eliminar 
        public void EliminarEmpleado(E_Empleado empleado)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_EliminarEmpleado", conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdEmpleado", empleado.Idempleado);
                command.ExecuteNonQuery();
                command.Parameters.Clear(); 

                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("No se pueden eliminar porque " +
                    "ya haces refrencia a este empleado en una entrada de leche, " +
                    "se generan ecepciones en la relacion de los datos en SQL");
            }
            
        }
        #endregion
        public void ActualizarEmpleado(E_Empleado empleado)
        {
            SqlCommand command = new SqlCommand("SP_ActualizarEmpleados", conexion.AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.AddWithValue("@IdEmpleado", empleado.Idempleado);
            command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
            command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
            command.Parameters.AddWithValue("@Puesto", empleado.Puesto);
            command.Parameters.AddWithValue("@Departmento", empleado.Departamento);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }
   }
}
