using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class D_Usuario: ConexionData
    {
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
                return true;
            }
            else
                return false;
        }
    }
}
