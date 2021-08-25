using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using MaterialSkin.Controls;

namespace CapaDatos
{
   public class D_Empleado: ConexionData
   {

        #region Metodo Listar empleados

        public DataTable ValoreMienbrosComboRecolector()
        {
            DataTable Valores = new DataTable();
            SqlCommand command = new SqlCommand("SP_ValoresComboRecolectoresEmpleados", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = command.ExecuteReader();
            Valores.Load(dataReader);
            dataReader.Close();
            CerrarConexion();

            return Valores;
        }

        public DataTable ListaEmpleados()  
        {
            DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("SP_SeleccionarTodosLosEmpleados", AbrirConexion());
            SqlQuery.CommandType = CommandType.StoredProcedure;
           
            SqlDataReader dataReader = SqlQuery.ExecuteReader();
             Listado.Load(dataReader);
            
             dataReader.Close();
            CerrarConexion();
             return Listado;
        }
        #endregion
        #region Metodo insertar
        public void InsertarEmpleados(E_Empleado empleado)
        {
            SqlCommand command = new SqlCommand("InsertEmpleado",AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
            command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
            command.Parameters.AddWithValue("@Puesto", empleado.Puesto);
            command.Parameters.AddWithValue("@Departmento", empleado.Departamento);
            command.Parameters.AddWithValue("@Apellido", empleado.Apellido);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        #endregion
        #region Metodo Eliminar 
        public void EliminarEmpleado(E_Empleado empleado)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_EliminarEmpleado", AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdEmpleado", empleado.Idempleado);
                command.ExecuteNonQuery();
                command.Parameters.Clear(); 

                CerrarConexion();
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Los datos de este Empleado entan relacionados a otros datos, no lo puede eliminar");
            }
            
        }
        #endregion
        public void ActualizarEmpleado(E_Empleado empleado)
        {
            SqlCommand command = new SqlCommand("SP_ActualizarEmpleados",AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.AddWithValue("@IdEmpleado", empleado.Idempleado);
            command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
            command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
            command.Parameters.AddWithValue("@Puesto", empleado.Puesto);
            command.Parameters.AddWithValue("@Departmento", empleado.Departamento);
            command.Parameters.AddWithValue("@Apellido", empleado.Apellido);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        public DataTable BuscarEmpleadosPorNombres(string valor)
        {

            SqlCommand query = new SqlCommand("SP_GetEmpleadosByName", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            query.Parameters.AddWithValue("@Nombre", valor);
            SqlDataReader dataReader = query.ExecuteReader();

            DataTable lista = new DataTable();

            lista.Load(dataReader);
            dataReader.Close();
            CerrarConexion();

            return lista;
        }
    }
}
