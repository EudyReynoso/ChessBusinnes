using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades.Cannom;
using MaterialSkin.Controls;

namespace CapaDatos
{
    public class D_Usuario: ConexionData
    {
        public DataTable ListaUsuarios()
        {
            DataTable Listado = new DataTable();
            SqlCommand SqlQuery = new SqlCommand("dbo.SP_SelectALLUsers ", AbrirConexion());
            SqlQuery.CommandType = CommandType.StoredProcedure;

            SqlDataReader dataReader = SqlQuery.ExecuteReader();
            Listado.Load(dataReader);

            dataReader.Close();
            CerrarConexion();
            return Listado;
        }

        public DataTable ValoreMienbrosComboRoles()
        {
            DataTable Valores = new DataTable();
            SqlCommand command = new SqlCommand("ValuesComboRolesUsuario", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader dataReader = command.ExecuteReader();
            Valores.Load(dataReader);
            dataReader.Close();
            CerrarConexion();

            return Valores;
        }
        public void InsertarUsuario(E_Usuario usuario)
        {
            SqlCommand command = new SqlCommand("SP_InsertNewUsuario", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@NombreUsuario", usuario.Loginname);
            command.Parameters.AddWithValue("@Contrasena", usuario.Password);
            command.Parameters.AddWithValue("@RoleId", usuario.RoleID);
            command.Parameters.AddWithValue("@Nombre", usuario.Firstname);
            command.Parameters.AddWithValue("@Apellido", usuario.Loginname);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        public void ActualizarUsuario(E_Usuario usuario)
        {
            SqlCommand command = new SqlCommand("SP_ActualizarUsuario", AbrirConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdUsuario", usuario.Iduruario);
            command.Parameters.AddWithValue("@NombreUsuario", usuario.Loginname);
            command.Parameters.AddWithValue("@Contrasena", usuario.Password);
            command.Parameters.AddWithValue("@RoleId", usuario.RoleID);
            command.Parameters.AddWithValue("@Nombre", usuario.Firstname);
            command.Parameters.AddWithValue("@Apellido", usuario.Lastname);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            CerrarConexion();
        }
        public void EliminarUsuario(E_Usuario usuario)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_EliminarUsuario", AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IdUsuario", usuario.Iduruario);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                CerrarConexion();
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Los datos de este Empleado entan relacionados a otros datos, no lo puede eliminar");
            }

        }
        public bool Login(E_Usuario usuario)
        {
            SqlCommand command = new SqlCommand("SP_ObtenerUsuarioyCOntrasena", AbrirConexion())
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@LoginName", usuario.Loginname);
            command.Parameters.AddWithValue("@Password", usuario.Password);

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    UserLoginChache.IdUsuario = dataReader.GetInt32(0);
                    UserLoginChache.Nombre = dataReader.GetString(4);
                    UserLoginChache.Apellido = dataReader.GetString(5);
                    UserLoginChache.Role = dataReader.GetInt32(3);
                }
                return true;
            }
            else
                return false;
        }
    }
}
