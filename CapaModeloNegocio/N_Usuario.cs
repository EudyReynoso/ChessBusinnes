using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaModeloNegocio
{
    public class N_Usuario
    {
        D_Usuario D_Usuario = new D_Usuario();

        public DataTable ListaUsuario()
        {
            return D_Usuario.ListaUsuarios();
        }
        public DataTable ValoresComboRoles()
        {
            return D_Usuario.ValoreMienbrosComboRoles();
        }
        public void InsertarUsuario(E_Usuario usuario)
        {
             D_Usuario.InsertarUsuario(usuario);
        }

        public void EliminarUsuario(E_Usuario usuario)
        {
            D_Usuario.EliminarUsuario(usuario);
        }
        public void ActualizarUsuario(E_Usuario usuario)
        {
            D_Usuario.ActualizarUsuario(usuario);
        }
        public bool LoginVales(E_Usuario usuario)
        {
            return D_Usuario.Login(usuario);
        }
    }
}
