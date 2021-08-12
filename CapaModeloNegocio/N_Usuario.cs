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

        public bool LoginVales(E_Usuario usuario)
        {
            return D_Usuario.Login(usuario);
        }
    }
}
