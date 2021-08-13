using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Usuario
    {
        private int _iduruario;
        private string _loginname;
        private string _password;
        private string _firstname;
        private string _lastname;
        private int _roleID;

        public int Iduruario { get => _iduruario; set => _iduruario = value; }
        public string Loginname { get => _loginname; set => _loginname = value; }
        public string Password { get => _password; set => _password = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public int RoleID { get => _roleID; set => _roleID = value; }
    }
}
