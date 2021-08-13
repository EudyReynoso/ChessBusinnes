using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Cannom
{
    public static class UserLoginChache
    {
        static int _IdUsuario;
        static string _Nombre;
        static string _Apellido;
        static int _Role;

        public static int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public static string Nombre { get => _Nombre; set => _Nombre = value; }
        public static string Apellido { get => _Apellido; set => _Apellido = value; }
        public static int Role { get => _Role; set => _Role = value; }
    }
}
